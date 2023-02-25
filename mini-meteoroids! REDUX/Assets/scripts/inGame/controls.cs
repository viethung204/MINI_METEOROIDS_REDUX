using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public int controlState;

    public GameObject control1;
    public GameObject control2;
    public GameObject control3;
    public GameObject control4;

    // Start is called before the first frame update
    void Start()
    {
        controlState = PlayerPrefs.GetInt("control", 1);

        if (controlState == 1)
        {
            control1.SetActive(true);
            control2.SetActive(false);
            control3.SetActive(false);
            control4.SetActive(false);
        }
        else if (controlState == 2)
        {
            control1.SetActive(false);
            control2.SetActive(true);
            control3.SetActive(false);
            control4.SetActive(false);
        }
        else if (controlState == 3)
        {
            control1.SetActive(false);
            control2.SetActive(false);
            control3.SetActive(true);
            control4.SetActive(false);
        }
        else if (controlState == 4)
        {
            control1.SetActive(false);
            control2.SetActive(false);
            control3.SetActive(false);
            control4.SetActive(true);
        }
    }

}
