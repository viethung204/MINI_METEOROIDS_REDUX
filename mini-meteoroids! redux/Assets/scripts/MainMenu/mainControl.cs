using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainControl : MonoBehaviour
{
    public GameObject playTriangle;
    public GameObject optionsTriangle;
    public GameObject quitTriangle;

    public GameObject MainHolder;
    public GameObject optionsHolder;
    public GameObject volumeTri;
    public GameObject resetTri;
    public GameObject backTri;

    public AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();

        playTriangle.SetActive(true);
        optionsTriangle.SetActive(false);
        quitTriangle.SetActive(false);

        MainHolder.SetActive(true);
        optionsHolder.SetActive(false);
    }

    public void DownButton()
    {
        if (playTriangle.activeInHierarchy == true)
        {
            selecting.Play();
            playTriangle.SetActive(false);
            optionsTriangle.SetActive(true);
        }
        else if (optionsTriangle.activeInHierarchy == true)
        {
            selecting.Play();
            optionsTriangle.SetActive(false);
            quitTriangle.SetActive(true);
        }
        else if (quitTriangle.activeInHierarchy == true)
        {
            return;
        }
    }

    public void UpButton()
    {
        if (playTriangle.activeInHierarchy == true)
        {
            return;
        }
        else if (optionsTriangle.activeInHierarchy == true)
        {
            selecting.Play();
            optionsTriangle.SetActive(false);
            playTriangle.SetActive(true);
        }
        else if (quitTriangle.activeInHierarchy == true)
        {
            selecting.Play();
            quitTriangle.SetActive(false);
            optionsTriangle.SetActive(true);
        }
    }

    public void EnterButton()
    {
        if (playTriangle.activeInHierarchy == true) Play();
        else if (optionsTriangle.activeInHierarchy == true) Options();
        else if (quitTriangle.activeInHierarchy == true) Quit();
    }

    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Options()
    {
        MainHolder.SetActive(false);
        optionsHolder.SetActive(true);
        volumeTri.SetActive(true);
        resetTri.SetActive(false);
        backTri.SetActive(false);
    }

    void Quit()
    {
        Application.Quit();
    }
}
