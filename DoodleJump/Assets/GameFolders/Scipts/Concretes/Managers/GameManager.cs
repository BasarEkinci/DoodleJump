using System;
using DoodleJump.Abstarcts;
using UnityEngine;

namespace DoodleJump.Managers
{
    public class GameManager : SingeltonThisObjects<GameManager>
    {
        private float score;
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

        private void Start()
        {
            SoundManager.Instance.StopSound(1);
        }

        private void Awake()
        {
            IsGameOver = false;
            SingeltonThisObject(this);
        }

        public void GameOver()
        {
            Debug.Log("Game Over");
            IsGameOver = true;
            SoundManager.Instance.PlaySound(1);
        }
    }
}

