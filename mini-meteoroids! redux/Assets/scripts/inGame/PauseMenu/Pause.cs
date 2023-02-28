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

    AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        game.SetActive(true);
        pauseMenuUI.SetActive(false);
        mainPause.SetActive(true);
        options.SetActive(false);

        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
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
        selecting.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pausing()
    {
        selecting.Play();
        pauseMenuUI.SetActive(true);
        mainPause.SetActive(true);
        options.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
