using DoodleJump.Abstarcts;
using UnityEngine;


namespace DoodleJump.Controllers.PlatformControllers
{
    public class PowerfulPlatformCOntroller : Platform
    {
        protected override void OnCollisionEnter2D(Collision2D collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();
            
            if (playerController != null && collision.GetContact(0).normal.y == -1f)
            {
                playerController.Jump(JumpForce * 2.5f);
                isCollide = true;
            }
            else
            {
                isCollide = false;
            }
        }
    }
}

