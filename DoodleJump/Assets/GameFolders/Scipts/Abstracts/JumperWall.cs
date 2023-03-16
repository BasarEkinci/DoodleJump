using System;
using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class JumperWall : MonoBehaviour
    {
        private bool isGorunded;

        public bool IsGrounded => isGorunded;

        
        private void OnCollisionEnter2D(Collision2D col)
        {

            if (col.collider != null && col.GetContact(0).normal.y == -1)
            {
                isGorunded = true;
            }
            else
            {
                isGorunded = false;
            }
        }
    }    
}


