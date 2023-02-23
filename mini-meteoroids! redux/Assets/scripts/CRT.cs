using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRT : MonoBehaviour
{
    int CRTState;

    CRTPostEffecter Main;
    CRTPostEffecter Back;

    // Start is called before the first frame update
    void Start()
    {
        CRTState = PlayerPrefs.GetInt("CRTState");
        Main = GameObject.Find("Main Camera").GetComponent<CRTPostEffecter>();
        Back = GameObject.Find("BackgroundCam").GetComponent<CRTPostEffecter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CRTState == 0)
        {
            Main.enabled = false;
            Back.enabled = false;
        }
        else
        {
            Main.enabled = true;
            Back.enabled = true;
        }
    }
}
