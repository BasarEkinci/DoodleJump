using DoodleJump.Managers;
using UnityEngine;


namespace DoodleJump.Spawners
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;

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
                EnemySpawn();
        }

        private void EnemySpawn()
        {
            spawnPos = new Vector3(0, transform.position.y, 0f);
            int spawner = (int)GameManager.Instance.Score;
            if (spawner % 50 == 0 && spawner >= 50)
            {
                Instantiate(enemyPrefab, spawnPos, transform.rotation);
                hasSpawned = true;
                Debug.Log("Enemy Spawned");
            }
        }
    }    
}

