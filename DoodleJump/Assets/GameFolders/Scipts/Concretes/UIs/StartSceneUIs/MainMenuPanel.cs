using System.Collections;
using System.Collections.Generic;
using DoodleJump.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

namespace DoodleJump.UIs.StartSceneUIs
{
    public class MainMenuPanel: MonoBehaviour
    {
        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject how2PlayPanel;
        [SerializeField] private GameObject informationPanel;
        private float revealDuration = 0.2f;
        public void PlayButton()
        {
            GameManager.Instance.RestartGame();
            SceneManager.LoadScene(1);
        }

        public void How2PlayButton()
        {
            how2PlayPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
        }

        public void InformationButton()
        {
            informationPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
        }
    }    
}

