using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pauseScore : MonoBehaviour
{
    public TextMeshProUGUI menuText;
    public GameObject warningText;

    // Update is called once per frame
    void Update()
    {
        menuText.text = "Your current score is: " + "<color=yellow>" + Scored.Score.ToString("00") + "</color>";

        if(Scored.Score > 0)
        {
            warningText.SetActive(true);
        }
        else
        {
            warningText.SetActive(false);
        }
    }
}
