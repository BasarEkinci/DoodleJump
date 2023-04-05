using DoodleJump.Enums;
using DoodleJump.Managers;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DoodleJump.Spawners
{
    public class PlatformSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] platforms;

        private float verticalLimit = 3f;
        private float horizontalLimit;
        private int amount = 100;
        private Vector3 spawnPos;
        private int platformChance;
        private int platformIndex;

        private void Start()
        {
            SpawnPlatform();
        }

        private void Update()
        {
            int spawner = (int)GameManager.Instance.Score % 100;
            if (spawner == 0)
            {
                amount = 10;
                SpawnPlatform();
            }
        }

        private void SpawnPlatform()
        {
            
            for (int i = 0; i < amount; i++)
            {
                platformIndex = PlatformChance();
                horizontalLimit = Random.Range(-4, 4);
                spawnPos = new Vector3(horizontalLimit, verticalLimit, 0); 
                var spawnedPlatform =Instantiate(platforms[platformIndex], spawnPos, quaternion.identity);
                if (platformIndex == (int)PlatformEnum.UselessPlatform)
                    verticalLimit += 1;
                else
                    verticalLimit += Random.Range(1f,4f);
                
                spawnPos.y = verticalLimit; 
            }
        }

        private int PlatformChance()
        {
            platformChance = Random.Range(0, 17);
            if (platformChance <= 8) platformIndex = (int)PlatformEnum.StaticPlatform;
            else if (platformChance > 8 && platformChance <= 11) platformIndex = (int)PlatformEnum.MoverPlatform;
            else if (platformChance > 11 && platformChance <= 13) platformIndex = (int)PlatformEnum.JumperPlatform;
            else if (platformChance > 13 && platformChance <= 15) platformIndex = (int)PlatformEnum.TemporaryPlatform;
            else if (platformChance > 15 && platformChance <= 17) platformIndex = (int)PlatformEnum.UselessPlatform;

            return platformIndex;
        }
    }
}