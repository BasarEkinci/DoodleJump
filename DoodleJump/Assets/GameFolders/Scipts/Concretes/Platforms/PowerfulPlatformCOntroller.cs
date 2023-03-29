using DoodleJump.Abstarcts;
using DoodleJump.Controllers;
using UnityEngine;


namespace DoodleJump.Platforms
{
    public class PowerfulPlatformCOntroller : Platform
    {
        protected override void OnCollisionEnter2D(Collision2D collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();
            
            if (playerController != null && collision.relativeVelocity.y <= 0f)
            {
                playerController.Jump(JumpForce * 1.5f);
                isCollide = true;
            }
            else
            {
                isCollide = false;
            }
        }
    }
}

