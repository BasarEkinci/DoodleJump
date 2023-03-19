using System;
using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class Platform : MonoBehaviour
    {
        
        protected bool isCollide;
        private Vector2 screenBounds;
        private int screenSize;
        public float JumpForce { get; protected set; }

        private void Start()
        {
            
            JumpForce = 500f;
        }

        protected virtual void OnCollisionEnter2D(Collision2D col)
        {
            PlayerController playerController = col.collider.GetComponent<PlayerController>();
            
            if (playerController != null && col.GetContact(0).normal.y == -1f)
            {
                playerController.Jump(JumpForce);
                isCollide = true;
            }
            else
            {
                isCollide = false;
            }
        }
    }
}


