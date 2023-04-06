using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoodleJump.UIs.StartSceneUIs
{
    public class How2PlayPanel : MonoBehaviour
    {
        [SerializeField] private GameObject how2PlayPanel;
        [SerializeField] private GameObject mainMenuPanel;

        public void CloseBUtton()
        {
            how2PlayPanel.SetActive(false);
            mainMenuPanel.SetActive(true);
        }
    }
}

