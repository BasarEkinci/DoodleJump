using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Objects
{
    public class BulletObject : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            PlayerController player = col.GetComponent<PlayerController>();

            if (player != null)
            {
                player.BulletCounter += 5;
                player.BulletCounter = Mathf.Min(player.BulletCounter, 20);
                Destroy(gameObject);
            }
        }
        
    }
}

