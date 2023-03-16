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

        [SerializeField] private float speed;
        [SerializeField] private float leftBound;
        [SerializeField] private float rightBound;

        private float direction;

        private void Update()
        {
            if (transform.position.x >= rightBound)
                direction = -1f;
            else if (transform.position.x <= leftBound)
                direction = 1f;
            
            transform.Translate(Vector2.right * (speed * direction * Time.deltaTime));
        }
    }    
}


