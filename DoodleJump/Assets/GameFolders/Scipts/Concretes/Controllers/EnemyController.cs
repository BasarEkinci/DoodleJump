using System;
using DoodleJump.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace DoodleJump.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform spawnPos;
        private float xBound = 5.5f;
        private float moveSpeed = 7f;
        private int direction = 1;

        private void Start()
        {
            InvokeRepeating("CreateBullet",1f,1.5f);
        }

        private void LateUpdate()
        {
            if (transform.position.x >= xBound)
            {
                direction = -1;
            }
            else if (transform.position.x <= -xBound)
            {
                direction = 1;
            }
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime * direction);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            PlayerController player = col.GetComponent<PlayerController>();

            if (player != null)
            {
                GameManager.Instance.GameOver();
            }
        }


        private void CreateBullet()
        {
            Instantiate(bulletPrefab,spawnPos.position,transform.rotation);
            Debug.Log("Bullet Created!");
        }
    }    
}


