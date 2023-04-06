using System;
using DoodleJump.Abstarcts;
using UnityEngine;


namespace DoodleJump.Managers
{
    public class GameManager : SingeltonThisObjects<GameManager>
    {
        private float score;
        private float highScore = 0;
        public bool IsGameOver { get; private set; }
        public float Score
        {
            get => score;

            set
            {
                if (value > score)
                    score = value;
            }
        }

        public float HighScore => highScore;

        private void Start()
        {
            SoundManager.Instance.StopSound(1);
        }

        private void Awake()
        {
            IsGameOver = false;
            SingeltonThisObject(this);
        }

        private void Update()
        {
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetFloat("High Score",highScore);
                PlayerPrefs.Save();
            }
        }

        public void GameOver()
        {
            IsGameOver = true;
            SoundManager.Instance.PlaySound(1);
        }
    }
}

