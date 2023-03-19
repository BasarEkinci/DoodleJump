using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


namespace DoodleJump.Controllers.PlatformControllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject[] platforms;
        
        private float verticalLimit = 3f;
        private float horizontalLimit = 5f;
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
            if (player.transform.position.y % 150 == 0)
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
            platformChance = Random.Range(0, 15);

            if (platformChance <= 5) platformIndex = 0;
            else if (platformChance > 5 && platformChance <= 8) platformIndex = 1;
            else if(platformChance >7 && platformChance <= 11) platformIndex = 2;
            else if (platformChance > 11 && platformChance <= 15) platformIndex = 3;
            
            return platformIndex;
        }
    }
}



