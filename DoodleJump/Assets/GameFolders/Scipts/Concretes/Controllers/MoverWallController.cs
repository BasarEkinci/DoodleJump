using System;
using System.Collections;
using System.Collections.Generic;
using DoodleJump.Abstarcts;
using Unity.VisualScripting;
using UnityEngine;


namespace DoodleJump.Controllers
{
    public class MoverWallController : JumperWall
    {

        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            Debug.Log(IsGrounded);
            if (IsGrounded)
            {
                spriteRenderer.color = new Color(113f, 100f, 100f, Mathf.Lerp(100,0,2f) * Time.deltaTime);
            }
        }
    }    
}


