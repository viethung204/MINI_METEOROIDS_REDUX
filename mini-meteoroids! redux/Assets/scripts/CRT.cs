using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRT : MonoBehaviour
{
    public int CRTState;

    CRTPostEffecter Main;

    // Start is called before the first frame update
    void Start()
    {
        Main = GameObject.Find("Main Camera").GetComponent<CRTPostEffecter>();
    }

    // Update is called once per frame
    void Update()
    {
        CRTState = PlayerPrefs.GetInt("CRTState", 1);
        if (CRTState == 0)
        {
            Main.enabled = false;
        }
        else
        {
            Main.enabled = true;
        }
    }
}
