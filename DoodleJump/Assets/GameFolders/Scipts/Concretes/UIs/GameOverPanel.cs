using DoodleJump.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DoodleJump.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        [Header("Game Over Panel")]
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text highScoreText;

        private void Update()
        {
            scoreText.text = GameManager.Instance.Score.ToString("0");
            highScoreText.text = GameManager.Instance.Score.ToString("0");
        }
        
        public void TryAgainButton()
        {
            if(gameOverPanel.activeSelf)
                gameOverPanel.SetActive(false);
            
            SceneManager.LoadScene(1);
        }

        public void ReturnToMainMenuButton()
        {
            SceneManager.LoadScene(0);
        }
    }    
}


