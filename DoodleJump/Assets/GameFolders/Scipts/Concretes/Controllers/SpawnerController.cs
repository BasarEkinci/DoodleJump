using System;
using DoodleJump.Enums;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


namespace DoodleJump.Controllers.PlatformControllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private GameObject[] platforms;

        private float verticalLimit = 3f;
        private float horizontalLimit = 5f;
        private int amount = 100;
        private Vector3 spawnPos;
        private int platformChance;
        private int platformIndex;

        private bool isInteger;
        
        private void Start()
        {
            SpawnPlatform();
        }

        private void Update()
        {
            if (player.position.y >= 150f && player.position.y <= 153f)
            {
                SpawnPlatform();
            }
        }

        private void SpawnPlatform()
        {
            for (int i = 0; i < amount; i++)
            {
                platformIndex = PlatformChance(); 
                spawnPos = new Vector3(Random.Range(-horizontalLimit, horizontalLimit), verticalLimit, 0); 
                Instantiate(platforms[platformIndex], spawnPos, quaternion.identity); 
                verticalLimit += Random.Range(1f, 3f); 
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



