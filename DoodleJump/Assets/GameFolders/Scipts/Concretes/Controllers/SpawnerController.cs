using UnityEngine;

namespace DoodleJump.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] private Transform playerPos;
        [SerializeField] private GameObject platformPrefab;
        
        private Vector2 screenB;
        private void Start()
        {
            screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                Camera.main.transform.position.z));
            SpawnPlatform();
        }

        private void Update()
        {
            screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                Camera.main.transform.position.z));
        }

        private void SpawnPlatform()
        {
            GameObject platform2 = Instantiate(platformPrefab);
            platform2.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), playerPos.position.y - 1f, 0);
            
            GameObject platform3 = Instantiate(platformPrefab);
            platform3.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), playerPos.position.y + 4f, 0);
            
            GameObject platform4 = Instantiate(platformPrefab);
            platform4.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), playerPos.position.y + 7f, 0);
            
            GameObject platform5 = Instantiate(platformPrefab);
            platform5.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), playerPos.position.y + 10f, 0);
            
            GameObject platform6 = Instantiate(platformPrefab);
            platform6.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), playerPos.position.y + 13f, 0);
        }
    }
}

