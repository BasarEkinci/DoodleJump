using System;
using DoodleJump.Abstarcts;
using DoodleJump.Inputs;
using UnityEngine;

namespace DoodleJump.Objects
{
    public class Bullet : MonoBehaviour
    {
        private void Start()
        {
            Destroy(gameObject,5f);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            Enemy enemy = col.GetComponent<Enemy>();
            if (enemy != null)
            {
                SoundManager.Instance.PlaySound(3);
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }
    }    
}

