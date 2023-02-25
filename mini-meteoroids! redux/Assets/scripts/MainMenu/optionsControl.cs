using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class optionsControl : MonoBehaviour
{

    public AudioSource selecting;

    public GameObject mainHolder;
    public GameObject optionsHolder;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    public void Back()
    {
        selecting.Play();
        mainHolder.SetActive(true);
        optionsHolder.SetActive(false);
    }

    public void ResetScore()
    {
        selecting.Play();
        PlayerPrefs.SetInt("MenuScore", 0);
    }
}
