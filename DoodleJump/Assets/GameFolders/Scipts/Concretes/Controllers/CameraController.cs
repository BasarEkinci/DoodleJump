using UnityEngine;

namespace DoodleJump.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float smoothSpeed = 0.125f;
        [SerializeField] private Vector3 offset;

        private void LateUpdate()
        {
            Vector3 desiredPos = target.position + offset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

            smoothedPos = new Vector3(transform.position.x, smoothedPos.y, transform.position.z);
            transform.position = smoothedPos;
        }
    }    
}


