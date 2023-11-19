using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SoundManager : MonoBehaviour
{
    public AudioClip mySound;
    public AudioClip buttonSound;
    public AudioClip walkSound;
    public AudioClip machineSound;


    private AudioSource audioSource;
    public float volume = 1.0f;
    public float buttonSoundVolume = 1.0f;
    public float walkSoundVolume = 1.0f;
    public float machineSoundVolume = 1.0f;



    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
   
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        
        audioSource.clip = mySound;

        PlaySound();
    }

    public void playButtonSound()
    {
        audioSource.clip = buttonSound;
        audioSource.volume = buttonSoundVolume;
        audioSource.Play();

    }

    public void PlaySound()
    {
        audioSource.volume = volume;
        audioSource.PlayOneShot(mySound);
    }
    public void machineSoundPlay()
    {
        audioSource.clip = machineSound;
        audioSource.volume = machineSoundVolume;
        audioSource.Play();
    }
}

