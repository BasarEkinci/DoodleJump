using System.Collections.Generic;
using DoodleJump.Managers;
using UnityEngine;


namespace DoodleJump.Spawners
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private List<GameObject> enemyPrefabs;

        private float spawnRate = 2f;
        private float nextSpawn = 1f;
        private bool hasSpawned = false;
        
        private Vector3 spawnPos;
        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                hasSpawned = false;
            }
            if(hasSpawned == false)
            {
                EnemySpawn();
                if (GameManager.Instance.Score >= 400)
                {
                    EnemySpawn();
                    EnemySpawn();
                }
            }
        }

        private void EnemySpawn()
        {
            spawnPos = new Vector3(Random.Range(-4.5f,4.5f), transform.position.y, 0f);
            int spawner = (int)GameManager.Instance.Score;
            if (spawner % 50 == 0 && spawner >= 50)
            {
                Instantiate(enemyPrefabs[Random.Range(0,enemyPrefabs.Count)], spawnPos, transform.rotation);
                hasSpawned = true;
            }
        }
    }    
}

