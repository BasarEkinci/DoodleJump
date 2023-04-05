using System;
using System.Collections.Generic;
using DoodleJump.Managers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DoodleJump.Spawners
{
    public class MeteorSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject meteorPrefab;
        [SerializeField] private List<Transform> spawnPoints;

        private int spawnChance;
        
        private void Start()
        {
            InvokeRepeating("SpawnMeteor",0f,2);
        }
        

        private void SpawnMeteor()
        {
            if(GameManager.Instance.IsGameOver) return;
            
            spawnChance = Random.Range(0, 5);
            if(spawnChance < 2)
                Instantiate(meteorPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)].position, transform.rotation);
        }
    }    
}


