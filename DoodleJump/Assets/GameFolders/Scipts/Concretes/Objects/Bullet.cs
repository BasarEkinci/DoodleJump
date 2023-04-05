using DoodleJump.Abstarcts;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    private float moveSpeed = 20f;
    private Rigidbody2D bulletRb;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.up * (moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Enemy enemy = col.GetComponent<Enemy>();
        if (enemy != null)
        {
            Destroy(col.gameObject);
        }
    }
}
