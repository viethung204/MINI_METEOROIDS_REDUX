using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRTControl : MonoBehaviour
{

    public SpriteRenderer box;
    public Sprite tickbox0;
    public Sprite tickbox1;

    public int CRTState = 0;
    CRTPostEffecter MainCam;
    CRTPostEffecter BackCam;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = GameObject.Find("Main Camera").GetComponent<CRTPostEffecter>();
        BackCam = GameObject.Find("BackgroundCam").GetComponent<CRTPostEffecter>();
    }

    // Update is called once per frame
    void Update()
    {
        CRTState = PlayerPrefs.GetInt("CRTState", 1);
        box.sprite = CRTState == 0 ? tickbox0
            : tickbox1;
            
        if(CRTState == 0)
        {
            MainCam.enabled = false;
            BackCam.enabled = false;
        }
        else
        {
            MainCam.enabled = true;
            BackCam.enabled = true;
        }
    }

    public void changeCRT()
    {
        CRTState = CRTState == 1 ? 0
            : 1;
        PlayerPrefs.SetInt("CRTState", CRTState);
    }
}
