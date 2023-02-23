using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject resumeTri;
    public GameObject optionsTri;
    public GameObject Q2MTri;
    public GameObject QuitTri;

    public GameObject volumeTri;
    public GameObject backTri;

    AudioSource selecting;

    public GameObject mainHolder;
    public GameObject optionsHolder;
    public Pause pause;

    // Start is called before the first frame update
    void Start()
    {
        resumeTri.SetActive(true);
        optionsTri.SetActive(false);
        Q2MTri.SetActive(false);
        QuitTri.SetActive(false);

        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    public void DownButton()
    {
        if (resumeTri.activeInHierarchy == true)
        {
            selecting.Play();
            resumeTri.SetActive(false);
            optionsTri.SetActive(true);
        }
        else if (optionsTri.activeInHierarchy == true)
        {
            selecting.Play();
            optionsTri.SetActive(false);
            Q2MTri.SetActive(true);
        }
        else if (Q2MTri.activeInHierarchy == true)
        {
            selecting.Play();
            Q2MTri.SetActive(false);
            QuitTri.SetActive(true);
        }
        else if (QuitTri.activeInHierarchy == true)
        {
            return;
        }
    }

    public void UpButton()
    {
        if (resumeTri.activeInHierarchy == true)
        {
            return;
        }
        else if (optionsTri.activeInHierarchy == true)
        {
            selecting.Play();
            optionsTri.SetActive(false);
            resumeTri.SetActive(true);
        }
        else if (Q2MTri.activeInHierarchy == true)
        {
            selecting.Play();
            Q2MTri.SetActive(false);
            optionsTri.SetActive(true);
        }
        else if (QuitTri.activeInHierarchy == true)
        {
            selecting.Play();
            QuitTri.SetActive(false);
            Q2MTri.SetActive(true);
        }
    }

    public void Enter()
    {
        if (resumeTri.activeInHierarchy == true) pause.Resume();
        else if (optionsTri.activeInHierarchy == true) Options();
        else if (Q2MTri.activeInHierarchy == true) Q2M();
        else if (QuitTri.activeInHierarchy == true) Quit();
    }

    public void Options()
    {
        mainHolder.SetActive(false);
        optionsHolder.SetActive(true);
        backTri.SetActive(false);
        volumeTri.SetActive(true);
    }

    void Q2M()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    void Quit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
