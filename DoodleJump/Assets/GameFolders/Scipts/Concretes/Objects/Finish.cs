using DoodleJump.Managers;
using UnityEngine;

namespace DoodleJump.Objects
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if(GameManager.Instance.IsGameOver) return;
            
            if(!col.CompareTag("Player"))
                Destroy(col.gameObject);
            else
                GameManager.Instance.GameOver();
        }
    }    
}


