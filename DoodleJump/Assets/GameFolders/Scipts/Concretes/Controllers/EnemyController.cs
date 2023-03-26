
using System.Collections;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform playerTransform;

        
        private void Update()
        {
            StartCoroutine("CreateBulletAsync");
            bulletPrefab.transform.position = Vector3.Lerp(bulletPrefab.transform.position,playerTransform.position,3f);
        }

        IEnumerator CreateBulletAsync()
        {
            yield return new WaitForSecondsRealtime(1f);
            Instantiate(bulletPrefab);
        }
    }    
}


