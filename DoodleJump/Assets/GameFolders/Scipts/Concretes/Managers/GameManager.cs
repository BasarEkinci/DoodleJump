using System;
using UnityEngine;

namespace DoodleJump.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        private float score;

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
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

