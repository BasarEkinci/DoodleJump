using DoodleJump.Inputs;
using DoodleJump.Managers;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private GameObject bullet;
        
        private Rigidbody2D playerRigidbody2D;
        private PlayerInputs input;
        private bool isFacingRight = true;
        private int bulletCounter = 20;

        public int BulletCounter
        {
            get => bulletCounter;
            set
            {

                bulletCounter = value;
            }
        }

        private bool IsJumping => playerRigidbody2D.velocity.y > 0.01f;
        
        private void Awake()
        {
            playerRigidbody2D = GetComponent<Rigidbody2D>();
            input = gameObject.AddComponent<PlayerInputs>();
        }

        private void Update()
        {
            GameManager.Instance.Score = transform.position.y;
            Flip();
            
            if(input.Shoot)
                CreateBulltet();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void CreateBulltet()
        {
            if (bulletCounter > 0)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                bulletCounter--;
            }
        }
        
        private void Move()
        {
            if (GameManager.Instance.IsGameOver) return;
            
            Vector3 position = transform.position;
            position.x += input.Direction * moveSpeed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x,-5.8f, 5.8f);
            transform.position = position;
        }
        public void Jump(float jumpForce)
        {
            if (GameManager.Instance.IsGameOver) return;
            
            if (!IsJumping)
                playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpForce * Time.deltaTime);
        }

        private void Flip()
        {
            if(GameManager.Instance.IsGameOver) return;
            
            if (isFacingRight && input.Direction < 0f || !isFacingRight && input.Direction > 0f)
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }
    }
}

