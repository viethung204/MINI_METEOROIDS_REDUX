using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadMenuControl : MonoBehaviour
{
    public GameObject replayTri;
    public GameObject Q2MTri;
    public GameObject QuitTri;

    public AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();

        replayTri.SetActive(true);
        Q2MTri.SetActive(false);
        QuitTri.SetActive(false);
    }

    public void UpButton()
    {
        if (replayTri.activeInHierarchy == true)
        {
            return;
        }
        else if (Q2MTri.activeInHierarchy == true)
        {
            selecting.Play();
            Q2MTri.SetActive(false);
            replayTri.SetActive(true);
        }
        else if (QuitTri.activeInHierarchy == true)
        {
            selecting.Play();
            QuitTri.SetActive(false);
            Q2MTri.SetActive(true);
        }
    }

    public void DownButton()
    {
        if (replayTri.activeInHierarchy == true)
        {
            selecting.Play();
            replayTri.SetActive(false);
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

    public void EnterButton()
    {
        if (replayTri.activeInHierarchy == true) Replay();
        else if (Q2MTri.activeInHierarchy == true) Q2M();
        else if (QuitTri.activeInHierarchy == true) Quit();
    }

    void Replay()
    {
        SceneManager.LoadScene(1);
    }

    void Q2M()
    {
        SceneManager.LoadScene(0);
    }

    void Quit()
    {
        Application.Quit();
    }
}
