using System;
using DoodleJump.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DoodleJump.UIs.GameSceneUIs
{
    public class GameOverPanel : MonoBehaviour
    {
        [Header("Game Over Panel")]
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text highScoreText;

        private void Update()
        {
            scoreText.text = "Score\n " + GameManager.Instance.Score.ToString("0");
            highScoreText.text = "High\nScore\n " + GameManager.Instance.HighScore.ToString("0");
        }
        public void TryAgainButton()
        {
            SceneManager.LoadScene(1);
            GameManager.Instance.RestartGame();
        }

        public void ReturnToMainMenuButton()
        {
            if(gameOverPanel.activeSelf)
                gameOverPanel.SetActive(false);
            
            GameManager.Instance.RestartGame();
            SceneManager.LoadScene(0);
        }
    }    
}


