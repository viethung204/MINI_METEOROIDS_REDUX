using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    AudioSource selecting;

    public GameObject mainHolder;
    public GameObject optionsHolder;
    public Pause pause;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }
    public void Options()
    {
        selecting.Play();
        mainHolder.SetActive(false);
        optionsHolder.SetActive(true);
    }

    public void Q2M()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
