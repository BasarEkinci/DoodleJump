using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryPlatformController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider != null)
        {
            Destroy(gameObject,0.3f);
        }
    }
}
