using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainControl : MonoBehaviour
{

    public GameObject MainHolder;
    public GameObject optionsHolder;

    public AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();

        MainHolder.SetActive(true);
        optionsHolder.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        selecting.Play();
        MainHolder.SetActive(false);
        optionsHolder.SetActive(true);
    }

    public void Controls()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
