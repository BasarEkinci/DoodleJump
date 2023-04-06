using System;
using DoodleJump.Controllers;
using DoodleJump.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DoodleJump.UIs
{
    public class GameUI : MonoBehaviour
    {
        [Header("Game Panel")]
        [SerializeField] private GameObject gamePanel;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text bulletText;

        [SerializeField] private PlayerController player;
        
        private void Start()
        {
            if(!gamePanel.activeSelf)
                gamePanel.SetActive(true);

        }

        private void Update()
        {
            scoreText.text = GameManager.Instance.Score.ToString("0");
            bulletText.text = player.BulletCounter.ToString("0");

            if (GameManager.Instance.IsGameOver)
            {
                if(gamePanel.activeSelf)
                    gamePanel.SetActive(false);

            }
            else
            {
                if(!gamePanel.activeSelf)
                    gamePanel.SetActive(true);
            }
        }
    }    
}


