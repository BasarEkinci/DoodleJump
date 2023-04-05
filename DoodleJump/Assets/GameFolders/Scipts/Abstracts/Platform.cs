using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class Platform : MonoBehaviour
    {
        
        protected bool isCollide;
        private int screenSize;
        public float JumpForce { get; protected set; }

        private void Start()
        {
            JumpForce = 550f;
        }

        protected virtual void OnCollisionEnter2D(Collision2D col)
        {
            PlayerController playerController = col.collider.GetComponent<PlayerController>();
            
            if (playerController != null && col.relativeVelocity.y <= 0f) 
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


