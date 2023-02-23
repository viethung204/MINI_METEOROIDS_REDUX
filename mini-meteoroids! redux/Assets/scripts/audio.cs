using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource[] allAudios;
    public float setVolume;

    // Update is called once per frame
    void Update()
    {
        setVolume = PlayerPrefs.GetInt("volume");
        allAudios = GameObject.FindObjectsOfType<AudioSource>();
        foreach(AudioSource audioSource in allAudios)
        {
            audioSource.volume = setVolume/10;
        }
    }
}
