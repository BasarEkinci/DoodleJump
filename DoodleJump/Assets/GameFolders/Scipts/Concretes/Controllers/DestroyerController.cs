using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class DestroyerController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(col.gameObject);
        }
    }    
}


