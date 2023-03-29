using System;
using UnityEngine;

namespace DoodleJump.Platforms
{
    public class UselessPlatformController : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider != null && col.relativeVelocity.y <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }    
}

