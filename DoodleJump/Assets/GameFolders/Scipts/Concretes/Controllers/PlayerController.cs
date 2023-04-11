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
            PlayerScreenPosition();
        }
        
        private void FixedUpdate()
        {
            Move();
            Flip();
        }

        private void PlayerScreenPosition()
        {
            if (transform.position.x > 6.1f + 0.3f)
                transform.position = new Vector3(-6.1f - 0.3f, transform.position.y, -5f);
            
            if (transform.position.x < -6.1f - 0.3f)
                transform.position = new Vector3(6.1f + 0.3f, transform.position.y, -5f);
            
        }

        // Shooting bullet------------------
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
        //-----------------------------------
        
        //Moving Left-Right------------------
        private void Move()
        {
            if (GameManager.Instance.IsGameOver) return;

            var moveDirection = Input.GetAxis("Horizontal");
            playerRigidbody2D.velocity = new Vector2(moveSpeed * Time.deltaTime * moveDirection, playerRigidbody2D.velocity.y);
        }
        //------------------------------------

        //to Jump-----------------------------
        public void Jump(float jumpForce)
        {
            if (GameManager.Instance.IsGameOver) return;
            
            if (!IsJumping)
            {
                SoundManager.Instance.PlaySound(0);
                playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpForce * Time.deltaTime);
            }
        }
        //------------------------------------
        
        //To flip Player------------------------------
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
        //-----------------------------------------------
    }
}

