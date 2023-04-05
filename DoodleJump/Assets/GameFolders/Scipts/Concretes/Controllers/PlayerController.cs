using DoodleJump.Inputs;
using DoodleJump.Managers;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private GameObject bulletPrefab;

        private Rigidbody2D playerRigidbody2D;
        private PlayerInputs input;
        private bool isFacingRight = true;
        private int bulletCounter = 20;
        

        public bool IsJumping => playerRigidbody2D.velocity.y > 0.01f;
        
        public int BulletCounter
        {
            get => bulletCounter;
            set => bulletCounter = value;
        }
        private void Awake()
        {
            playerRigidbody2D = GetComponent<Rigidbody2D>();
            input = gameObject.AddComponent<PlayerInputs>();
        }

        private void Update()
        {
            if (GameManager.Instance.IsGameOver) return;
            
            if(bulletCounter > 0)
                CreateBullet();
            
            GameManager.Instance.Score = transform.position.y;
            Flip();
        }

        private void FixedUpdate()
        {
            Move();

        }
        //--------------------------
        // Shooting bullet
        private void CreateBullet()
        {
            if (input.Shoot)
            {
                SoundManager.Instance.PlaySound(2);
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.up * 15;
                bulletCounter--;
            }
        }
        //Shooting Bullet
        //--------------------------------
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
            {
                SoundManager.Instance.PlaySound(0);
                playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpForce * Time.deltaTime);
            }
            
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

