using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    int hiscore;
    public TextMeshProUGUI hiscoreText;

    // Start is called before the first frame update
    void Start()
    {
       // hiscore = PlayerPrefs.GetInt("MenuScore");

    }

    // Update is called once per frame
    void Update()
    {
        hiscore = PlayerPrefs.GetInt("MenuScore");
        hiscoreText.text = "current hi-score: " + "<color=yellow>" + hiscore + "</color>";
    }
}
