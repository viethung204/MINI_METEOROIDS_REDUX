using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    AudioSource selecting;

    public GameObject mainPause;
    public GameObject optionsHolder;


    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    public void Back()
    {
        selecting.Play();
        optionsHolder.SetActive(false);
        mainPause.SetActive(true);
    }
}
