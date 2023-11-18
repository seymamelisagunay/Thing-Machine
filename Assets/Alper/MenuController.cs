using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject playButton;
    public GameObject creditsButton;
    public GameObject backButton;
    public GameObject creditsPanel;

    void Start()
    {
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        creditsPanel.SetActive(false);
        backButton.SetActive(false);
    }

    public void PlayButtonClicked()
    {   
        SceneManager.LoadScene(0);
    }

    public void CreditsButtonClicked()
    {
        Debug.Log("armutspor");
        playButton.SetActive(false);
        creditsPanel.SetActive(true);
        backButton.SetActive(true);
        creditsButton.SetActive(false);

       
    }

    public void BackButtonClicked()
    {
        playButton.SetActive(true);
        creditsPanel.SetActive(false);
        creditsButton.SetActive(true);
        backButton.SetActive(false);
    }
}
