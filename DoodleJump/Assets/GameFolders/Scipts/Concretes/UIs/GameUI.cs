using DoodleJump.Managers;
using TMPro;
using UnityEngine;

namespace DoodleJump.UIs
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;

        private void Update()
        {
            scoreText.text = GameManager.Instance.Score.ToString("0");
        }
    }    
}


