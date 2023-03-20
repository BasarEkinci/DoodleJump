using UnityEngine;

namespace DoodleJump.Objects
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                Debug.Log("GameOver");
            }

            if (col.gameObject.CompareTag("Obtacle"))
            {
                Destroy(col.gameObject);
            }
        }
    }    
}


