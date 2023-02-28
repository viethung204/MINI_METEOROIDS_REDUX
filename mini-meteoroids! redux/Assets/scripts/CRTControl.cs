using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRTControl : MonoBehaviour
{

    public Image box;
    public Sprite tickbox0;
    public Sprite tickbox1;

    public int CRTState = 0;
    public CRTPostEffecter MainCam;

    public AudioSource selecting;

    private void Start()
    {
        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
        CRTState = PlayerPrefs.GetInt("CRTState", 1);
        if (CRTState == 0)
        {
            MainCam.enabled = false;
        }
        else
        {
            MainCam.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //CRTState = PlayerPrefs.GetInt("CRTState", 1);
        box.sprite = CRTState == 0 ? tickbox0
            : tickbox1;

        //if (crtstate == 0)
        //{
        //    maincam.enabled = false;
        //}
        //else
        //{
        //    maincam.enabled = true;
        //}
    }

    public void changeCRT()
    {
        selecting.Play();
        CRTState = CRTState == 1 ? 0
            : 1;
        PlayerPrefs.SetInt("CRTState", CRTState);
        if (CRTState == 0)
        {
            MainCam.enabled = false;
        }
        else
        {
            MainCam.enabled = true;
        }

        box.sprite = CRTState == 0 ? tickbox0
            : tickbox1;
    }
}
