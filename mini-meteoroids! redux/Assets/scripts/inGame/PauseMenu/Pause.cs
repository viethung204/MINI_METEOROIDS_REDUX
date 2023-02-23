using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;
    public GameObject game;
    public GameObject mainPause;
    public GameObject options;

    public GameObject resumeTri;
    public GameObject optionsTri;
    public GameObject q2mTri;
    public GameObject quitTri;
    public GameObject volumeTri;

    // Start is called before the first frame update
    void Start()
    {
        game.SetActive(true);
        pauseMenuUI.SetActive(false);
        mainPause.SetActive(true);
        options.SetActive(false);
    }

    public void OnPause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pausing();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pausing()
    {
        pauseMenuUI.SetActive(true);
        mainPause.SetActive(true);
        options.SetActive(false);
        resumeTri.SetActive(true);
        optionsTri.SetActive(false);
        q2mTri.SetActive(false);
        quitTri.SetActive(false);
        volumeTri.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
