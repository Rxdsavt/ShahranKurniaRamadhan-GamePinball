using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSourceBumper;
    public GameObject sfxAudioSourceSwitch;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void StopBGM()
    {
        bgmAudioSource.Stop();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSourceBumper, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSourceSwitch, spawnPosition, Quaternion.identity);
    }
}
