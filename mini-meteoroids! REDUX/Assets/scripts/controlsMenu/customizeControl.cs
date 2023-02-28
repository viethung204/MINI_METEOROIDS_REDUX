using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class customizeControl : MonoBehaviour
{
    public GameObject control1;
    public GameObject control2;
    public GameObject control3;
    public GameObject control4;

    public int controlState;

    public AudioSource selecting;

    public TextMeshProUGUI number;


    // Start is called before the first frame update
    void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
        controlState = PlayerPrefs.GetInt("control", 1);
    }

    // Update is called once per frame
    void Update()
    {
        number.text = "<color=yellow>" + controlState + "</color>/4";

        //if(controlState == 1)
        //{
        //    control1.SetActive(true);
        //    control2.SetActive(false);
        //    control3.SetActive(false);
        //    control4.SetActive(false);
        //}
        //else if(controlState == 2)
        //{
        //    control1.SetActive(false);
        //    control2.SetActive(true);
        //    control3.SetActive(false);
        //    control4.SetActive(false);
        //}
        //else if(controlState == 3)
        //{
        //    control1.SetActive(false);
        //    control2.SetActive(false);
        //    control3.SetActive(true);
        //    control4.SetActive(false);
        //}
        //else if(controlState == 4)
        //{
        //    control1.SetActive(false);
        //    control2.SetActive(false);
        //    control3.SetActive(false);
        //    control4.SetActive(true);
        //}
    }

    public void RightButton()
    {
        selecting.Play();
        controlState = controlState == 1 ? 2
            : controlState == 2 ? 3
            : controlState == 3 ? 4
            : 4;
        changingNumber();
        PlayerPrefs.SetInt("control", controlState);
    }

    public void LeftButton()
    {
        selecting.Play();
        controlState = controlState == 4 ? 3
            : controlState == 3 ? 2
            : controlState == 2 ? 1
            : 1;
        changingNumber();
        PlayerPrefs.SetInt("control", controlState);
    }

    public void changingNumber()
    {
       if(controlState == 1)
        {
            control1.SetActive(true);
            control2.SetActive(false);
            control3.SetActive(false);
            control4.SetActive(false);
        }
        else if(controlState == 2)
        {
            control1.SetActive(false);
            control2.SetActive(true);
            control3.SetActive(false);
            control4.SetActive(false);
        }
        else if(controlState == 3)
        {
            control1.SetActive(false);
            control2.SetActive(false);
            control3.SetActive(true);
            control4.SetActive(false);
        }
        else if(controlState == 4)
        {
            control1.SetActive(false);
            control2.SetActive(false);
            control3.SetActive(false);
            control4.SetActive(true);
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
