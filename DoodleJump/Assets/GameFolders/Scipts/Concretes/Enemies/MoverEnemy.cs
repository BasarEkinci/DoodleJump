using DoodleJump.Abstarcts;
using UnityEngine;

namespace DoodleJump.Enemies
{
    public class MoverEnemy : Enemy
    {
        private float xBound = 4.5f;
        private float moveSpeed = 6f;
        private int direction = 1;

        private void LateUpdate()
        {
            if (transform.position.x >= xBound)
                direction = -1;
            else if (transform.position.x <= -xBound)
                direction = 1;

            transform.position += Vector3.right * (moveSpeed * Time.deltaTime * direction);
        }
    }
}

