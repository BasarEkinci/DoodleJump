using System;
using DoodleJump.Controllers;
using DoodleJump.Managers;
using TMPro;
using UnityEngine;

namespace DoodleJump.UIs
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text bulletText;
        [SerializeField] private PlayerController player;

        private void Update()
        {
            scoreText.text = GameManager.Instance.Score.ToString("0");
            bulletText.text = player.BulletCounter.ToString("0");
        }
    }    
}


