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
        Time.timeScale = 0f;
        isPaused = true;
    }
}
