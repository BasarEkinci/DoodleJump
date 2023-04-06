using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMediaPanel : MonoBehaviour
{
    [SerializeField] private GameObject socialMediaPanel;
    [SerializeField] private GameObject mainMenuPanel;

    public void ClosePanel()
    {
        socialMediaPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    
    public void InstagramButton()
    {
        Application.OpenURL("https://www.instagram.com/basar.ekincii/");
    }

    public void TwitterButton()
    {
        Application.OpenURL("https://twitter.com/BasarEkincii");
    }

    public void LinkedinButton()
    {
        Application.OpenURL("https://www.linkedin.com/in/ismail-basar-ekinci-446674202/");
    }

    public void GitHubButton()
    {
        Application.OpenURL("https://github.com/BasarEkinci");
    }
}
