using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class JumperWall : MonoBehaviour
    {
        private bool isGorunded;

        public bool IsGrounded => isGorunded;
        
        private void OnCollisionEnter2D(Collision2D col)
        {
            PlayerController player = GetComponent<PlayerController>();

            if (player != null && col.GetContact(0).normal.y == -1)
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


