using DoodleJump.Controllers;
using UnityEngine;

namespace DoodleJump.Abstarcts
{
    public abstract class Platform : MonoBehaviour
    {
        
        private float jumpForce = 500f;
        protected bool isCollide;
        private Vector2 screenBounds;
        public float JumpForce => jumpForce;

        private void Update()
        {
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                Camera.main.transform.position.z));

            if (transform.position.y < screenBounds.y - 12)
            {
                transform.position = new Vector2(Random.Range(-screenBounds.x,screenBounds.x), screenBounds.y + 3);
            }
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            PlayerController playerController = col.collider.GetComponent<PlayerController>();
            
            if (playerController != null && col.GetContact(0).normal.y == -1f)
            {
                playerController.Jump(jumpForce);
                isCollide = true;
            }
            else
            {
                isCollide = false;
            }
        }
    }
}


