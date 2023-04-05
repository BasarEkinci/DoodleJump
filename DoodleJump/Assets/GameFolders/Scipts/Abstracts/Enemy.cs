using DoodleJump.Controllers;
using DoodleJump.Managers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class Enemy : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            PlayerController player = col.GetComponent<PlayerController>();

            if (player != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }    
}

