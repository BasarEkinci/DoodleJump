using UnityEngine;

namespace DoodleJump.Objects
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(col.gameObject);
        }
    }    
}


