using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class Platform : MonoBehaviour
    {
        
        private float jumpForce = 500f;
        protected bool isCollide;
        public float JumpForce => jumpForce;
        private void OnCollisionEnter2D(Collision2D col)
        {
            PlayerController playerController = col.collider.GetComponent<PlayerController>();
            
            if (playerController != null && col.GetContact(0).normal.y == -1f)
            {
                playerController.Jump(jumpForce);
                isCollide = true;
            }
            else
            {
                isCollide = false;
            }
        }
    }
}


