using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scored : MonoBehaviour
{
    public static int Score = 0;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString("00");
    }

    public void METDestroyed(int score)
    {
        Score += score;
    }
}
