using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    public GameObject volumeTri;
    public GameObject backTri;

    AudioSource selecting;

    public GameObject mainPause;
    public GameObject optionsHolder;
    public GameObject resumeTri;
    public GameObject optionsTri;

    public TextMeshProUGUI left;
    public TextMeshProUGUI right;


    // Start is called before the first frame update
    void Start()
    {
        volumeTri.SetActive(true);
        backTri.SetActive(false);

        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (volumeTri.activeInHierarchy == true)
        {
            left.text = "DECREASE";
            right.text = "INCREASE";
        }
        else
        {
            left.text = "ENTER";
            right.text = "ENTER";
        }
    }

    public void DownButton()
    {
        if (volumeTri.activeInHierarchy == true)
        {
            selecting.Play();
            volumeTri.SetActive(false);
            backTri.SetActive(true);
        }
        else if (backTri.activeInHierarchy == true)
        {
            return;
        }
    }

    public void UpButton()
    {
        if (volumeTri.activeInHierarchy == true)
        {
            return;
        }

        else if (backTri.activeInHierarchy == true)
        {
            selecting.Play();
            backTri.SetActive(false);
            volumeTri.SetActive(true);
        }
    }

    public void EnterButtonLeft()
    {
        if (volumeTri.activeInHierarchy == true) audioController.DecreaseVolume();
        else if (backTri.activeInHierarchy == true) Back();
    }

    public void EnterButtonRight()
    {
        if (volumeTri.activeInHierarchy == true) audioController.IncreaseVolume();
        else if (backTri.activeInHierarchy == true) Back();
    }

    public void Back()
    {
        optionsHolder.SetActive(false);
        mainPause.SetActive(true);
        optionsTri.SetActive(false);
        resumeTri.SetActive(true);
    }
}
