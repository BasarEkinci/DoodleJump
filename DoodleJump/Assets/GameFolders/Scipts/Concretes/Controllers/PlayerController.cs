using System;
using DoodleJump.Inputs;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D playerRigidbody2D;
        [SerializeField] private float moveSpeed; 
        private PlayerInputs input;
        
        private void Awake()
        {
            playerRigidbody2D = GetComponent<Rigidbody2D>();
            input = gameObject.AddComponent<PlayerInputs>();
        }

        private void FixedUpdate()
        {
            playerRigidbody2D.velocity =
                new Vector2(moveSpeed * input.Direction * Time.deltaTime, playerRigidbody2D.velocity.y);
        }
        

        public void Jump(float jumpForce)
        {
            playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpForce * Time.deltaTime);
        }  
    }
}

