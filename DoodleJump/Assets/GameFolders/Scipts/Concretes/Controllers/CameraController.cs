using DoodleJump.Managers;
using UnityEngine;

namespace DoodleJump.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float smoothSpeed;
        private void LateUpdate()
        {
            if(GameManager.Instance.IsGameOver) return;
            
            if (target.position.y > transform.position.y)
            {
                Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
            }
        }
    }    
}


