using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public int score;
    public int oldScore;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI congratsText;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("NewScore");
        oldScore = PlayerPrefs.GetInt("MenuScore");

        scoreText.text = "Your score is: " + "<color=yellow>"+score+"</color>";

        if (score > oldScore)
        {
            congratsText.enabled = true;
            PlayerPrefs.SetInt("MenuScore", score);
        }
        else
        {
            congratsText.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(score > oldScore)
        //{
        //    congratsText.enabled = true;
        //    PlayerPrefs.SetInt("MenuScore", score);
        //}
        //else
        //{
        //    congratsText.enabled = false;
        //}
    }
}
