using System;
using UnityEngine;

namespace DoodleJump.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        private float score;
        public bool IsGameOver { get; private set; }

        private void Start()
        {
            IsGameOver = false;
        }

        public float Score
        {
            get => score;

            set
            {
                if (value > score)
                    score = value;
            }
        }

        private void Awake()
        {
            Singelton();
        }

        private void Singelton()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            Debug.Log("Game Over");
            IsGameOver = true;
        }
    }
}

