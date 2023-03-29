using System;
using DoodleJump.Controllers;
using DoodleJump.Managers;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private float moveSpeed = 10f;
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        Destroy(gameObject,2);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerController player = col.GetComponent<PlayerController>();

        if (player != null)
        {
            Destroy(col.gameObject);
            GameManager.Instance.GameOver();
        }
    }
}
