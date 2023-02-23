using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class optionsControl : MonoBehaviour
{
    public GameObject volumeTri;
    public GameObject resetTri;
    public GameObject backTri;

    public TextMeshProUGUI enterLeft;
    public TextMeshProUGUI enterRight;

    public AudioSource selecting;

    public GameObject mainHolder;
    public GameObject optionsHolder;
    public GameObject playTri;
    public GameObject optionsTri;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();

        volumeTri.SetActive(true);
        resetTri.SetActive(false);
        backTri.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(volumeTri.activeInHierarchy == true)
        {
            enterLeft.text = "decrease";
            enterRight.text = "increase";
        }
        else
        {
            enterRight.text = "enter";
            enterLeft.text = "enter";
        }
    }

    public void UpButton()
    {
        if (volumeTri.activeInHierarchy == true)
        {
            return;
        }
        else if (resetTri.activeInHierarchy == true)
        {
            selecting.Play();
            resetTri.SetActive(false);
            volumeTri.SetActive(true);
        }
        else if (backTri.activeInHierarchy == true)
        {
            selecting.Play();
            backTri.SetActive(false);
            resetTri.SetActive(true);
        }
    }

    public void DownButton()
    {
        if (volumeTri.activeInHierarchy == true)
        {
            selecting.Play();
            volumeTri.SetActive(false);
            resetTri.SetActive(true);
        }
        else if (resetTri.activeInHierarchy == true)
        {
            selecting.Play();
            resetTri.SetActive(false);
            backTri.SetActive(true);
        }
        else if (backTri.activeInHierarchy == true)
        {
            return;
        }
    }

    public void EnterRight()
    {
        if (resetTri.activeInHierarchy == true) ResetScore();
        else if (volumeTri.activeInHierarchy == true) audioController.IncreaseVolume();
        else if (backTri.activeInHierarchy == true) Back();
    }

    public void EnterLeft()
    {
        if (resetTri.activeInHierarchy == true) ResetScore();
        else if (volumeTri.activeInHierarchy == true) audioController.DecreaseVolume();
        else if (backTri.activeInHierarchy == true) Back();
    }

    public void Back()
    {
        mainHolder.SetActive(true);
        optionsHolder.SetActive(false);
        playTri.SetActive(true);
        optionsTri.SetActive(false);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("MenuScore", 0);
    }
}
