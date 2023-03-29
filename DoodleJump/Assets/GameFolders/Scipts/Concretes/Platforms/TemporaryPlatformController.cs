using System;
using DoodleJump.Abstarcts;
using Unity.VisualScripting;
using UnityEngine;

namespace DoodleJump.Platforms
{
    public class TemporaryPlatformController : Platform
    {
        protected override void OnCollisionEnter2D(Collision2D col)
        {
            base.OnCollisionEnter2D(col);
            if (isCollide)
            {
                Destroy(gameObject);
            }
        }
    }    
}


