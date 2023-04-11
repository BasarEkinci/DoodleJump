using System;
using DoodleJump.Abstarcts;
using UnityEngine;


namespace DoodleJump.Managers
{
    public class GameManager : SingeltonThisObjects<GameManager>
    {
        private float score;
        private float highScore = 0;
        public bool IsGameOver { get;  set; }
        public float Score
        {
            get => score;
            set
            {
                if (value > score)
                    score = value;
                if (IsGameOver)
                    score = 0;
            }
        }

        public float HighScore => highScore;
        private void Awake()
        {
            IsGameOver = false;
            SingeltonThisObject(this);
        }
        private void Start()
        {
            SoundManager.Instance.StopSound(1);
        }
        private void Update()
        {
            if (Score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetFloat("High Score",highScore);
            }
        }
        public void GameOver()
        {
            IsGameOver = true;
            SoundManager.Instance.PlaySound(1);
        }
        public void RestartGame()
        {
            IsGameOver = false;
        }
    }
}

