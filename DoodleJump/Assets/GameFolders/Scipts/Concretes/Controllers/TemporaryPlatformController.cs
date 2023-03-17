using System;
using DoodleJump.Abstarcts;
using Unity.VisualScripting;
using UnityEngine;

namespace DoodleJump.Controllers 
{
    public class TemporaryPlatformController : Platform
    {
        private void OnCollisionExit2D(Collision2D other)
        {
            if(isCollide)
                Destroy(gameObject,0.3f);
        }
    }    
}


