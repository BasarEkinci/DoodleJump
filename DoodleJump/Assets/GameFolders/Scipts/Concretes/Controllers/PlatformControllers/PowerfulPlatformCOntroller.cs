using System;
using System.Collections;
using System.Collections.Generic;
using DoodleJump.Abstarcts;
using UnityEngine;

namespace DoodleJump.Controllers.PlatformControllers
{
    public class PowerfulPlatformCOntroller : Platform
    {
        private void OnCollisionExit2D(Collision2D other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (isCollide)
            {
                player.Jump(50000f);
            }
                
        }
    }
}

