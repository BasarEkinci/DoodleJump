using UnityEngine;

namespace DoodleJump.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D playerRb;
        private bool isGrounded;
        [SerializeField] private float jumpForce;
        [SerializeField] private float moveSpeed;
        private Transform gorundCheck;
        private bool isFacingRight;
        private float direction;
        
        private void Awake()
        {
            playerRb = GetComponent<Rigidbody2D>();
            gorundCheck = this.transform;
        }
    
        private void Update()
        {
            direction = Input.GetAxis("Horizontal");
            Flip();
        }
        
        public void FixedUpdate()
        {
            if (isGrounded)
            {
                playerRb.velocity = new Vector2(playerRb.velocity.x,jumpForce);
                isGrounded = false;
            }
            playerRb.velocity = new Vector2(direction * moveSpeed,playerRb.velocity.y);
            
        }
    
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider != null && col.GetContact(0).normal.y == 1)
            {
                isGrounded = true;
                playerRb.velocity = new Vector2(playerRb.velocity.x, 0f);
            }
        }
    
        private void Flip()
        {
            if (isFacingRight && direction < 0f || !isFacingRight && direction > 0f)
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }
    }
    
}

