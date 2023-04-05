using System;
using System.Numerics;
using DoodleJump.Abstarcts;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace DoodleJump.Enemies
{
    public class Meteor : Enemy
    {
        private float xPos;
        private float moveSpeed = 10f;
        private void Start()
        {
            xPos = transform.position.x;
        }

        private void Update()
        {
            if (xPos > 0)
                transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
            else
                transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
            
            Destroy(gameObject,4f);
            
            transform.Rotate(Vector3.forward,1);
        }
    }    
}

