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
    public SoundManager soundManager;

    void Start()
    {
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        creditsPanel.SetActive(false);
        backButton.SetActive(false);
    }

    public void PlayButtonClicked()
    {
        soundManager.playButtonSound();
        StartCoroutine(WaitAndLoadScene());     //bekletmeyi baþlatma kodu

    }

    public void CreditsButtonClicked()
    {
        Debug.Log("armutspor");
        soundManager.playButtonSound();


        playButton.SetActive(false);
        creditsPanel.SetActive(true);
        backButton.SetActive(true);
        creditsButton.SetActive(false);

       
    }

    public void BackButtonClicked()
    {
        soundManager.playButtonSound();


        playButton.SetActive(true);
        creditsPanel.SetActive(false);
        creditsButton.SetActive(true);
        backButton.SetActive(false);
    }
    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(soundManager.buttonSound.length); // Sesin uzunluðu kadar bekle

        SceneManager.LoadScene(0);
    }
}
