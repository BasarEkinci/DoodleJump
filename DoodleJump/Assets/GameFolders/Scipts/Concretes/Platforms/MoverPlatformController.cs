using DoodleJump.Abstarcts;
using UnityEngine;


namespace DoodleJump.Platforms
{
    public class MoverPlatformController : Platform
    {

        [SerializeField] private float speed;
        [SerializeField] private float leftBound;
        [SerializeField] private float rightBound;

        private float direction = 1;

        private void Update()
        {
            if (transform.position.x > rightBound)
                direction = -1f;
            else if (transform.position.x < leftBound)
                direction = 1f;
            
            transform.Translate(Vector2.right * (speed * direction * Time.deltaTime));
        }
    }    
}


