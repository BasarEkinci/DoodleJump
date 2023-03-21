using System;
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
            /*if(verticalLimit < 300)
                platformChance = Random.Range(0, 15);
            else if (verticalLimit > 300f && verticalLimit < 600f)
                platformChance = Random.Range(5, 15);
            else if (verticalLimit > 600f && verticalLimit < 700f)
                platformChance = Random.Range(5, 8);
            else if (verticalLimit > 700f && verticalLimit < 800f)
                platformChance = Random.Range(11, 15);*/

            platformChance = Random.Range(0, 20);
            
            if (platformChance <= 5) platformIndex = 0;
            else if (platformChance > 5 && platformChance <= 8) platformIndex = 1;
            else if(platformChance > 8 && platformChance <= 11) platformIndex = 2;
            else if (platformChance > 11 && platformChance <= 15) platformIndex = 3;
            else if (platformChance > 15 && platformChance <= 20) platformIndex = 4;
            
            return platformIndex;
        }
    }
}



