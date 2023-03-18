using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


namespace DoodleJump.Controllers.PlatformControllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] private GameObject[] platforms;

        private float verticalLimit = 3f;
        private float horizontalLimit = 5f;
        private int amount = 100;
        private Vector3 spawnPos;


        private void Start()
        {
            SpawnPlatform();
        }

        private void SpawnPlatform()
        {
            for (int i = 0; i < amount; i++)
            {
                int platformIndex = Random.Range(0,platforms.Length);
                spawnPos = new Vector3(Random.Range(-horizontalLimit, horizontalLimit), verticalLimit, 0);
                Instantiate(platforms[platformIndex], spawnPos, quaternion.identity);
                verticalLimit += Random.Range(1f, 3f);
                spawnPos.y = verticalLimit;
            }
        }
    }
}



