using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody2D _rb;
   private PlayerAnimation _playerAnim;
   private SpriteRenderer _playerSprite;
   
   [SerializeField] private float _speed = 3.0f;

   void Start()
   {
      _rb = GetComponent<Rigidbody2D>();
      _playerAnim = GetComponent<PlayerAnimation>();
      _playerSprite = GetComponentInChildren<SpriteRenderer>();
   }

   private void Update()
   {
      Movement();
   }

   void Movement()
   {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontalInput);
      transform.Translate(Vector3.up * Time.deltaTime * _speed * verticalInput);
      
      if (horizontalInput > 0)
      {
         Flip(true);
      }
      else if(horizontalInput < 0)

      {
         Flip(false);
      }

      _playerAnim.Move(horizontalInput);
   }
   
   private void Flip(bool faceRight)
   {
      if (faceRight == true)
      {
         _playerSprite.flipX = false;
      }
      else if (faceRight == false)
      {
         _playerSprite.flipX = true;
      }



   }
   
   
   
   
}


