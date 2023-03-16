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
            
        }
    }    
}


