using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class audioController : MonoBehaviour
{
    public SpriteRenderer volumeSlider;
    public Sprite slider0;
    public Sprite slider1;
    public Sprite slider2;
    public Sprite slider3;
    public Sprite slider4;
    public Sprite slider5;
    public Sprite slider6;
    public Sprite slider7;
    public Sprite slider8;
    public Sprite slider9;
    public Sprite slider10;

    public TextMeshProUGUI volumeText;
    static int volume;

    public GameObject volumeTri;

    private void Start()
    {
        //volume = PlayerPrefs.GetInt("volume");
    }

    // Update is called once per frame
   void Update()
    {
        volume = PlayerPrefs.GetInt("volume", 10);
        volumeText.text = volume.ToString("00");

        volumeSlider.sprite = volume == 0 ? slider0
            : volume == 1 ? slider1
            : volume == 2 ? slider2
            : volume == 3 ? slider3
            : volume == 4 ? slider4
            : volume == 5 ? slider5
            : volume == 6 ? slider6
            : volume == 7 ? slider7
            : volume == 8 ? slider8
            : volume == 9 ? slider9
            : slider10;
   }

    public static void DecreaseVolume()
    {
        volume = volume == 10 ? 9
                    : volume == 9 ? 8
                    : volume == 8 ? 7
                    : volume == 7 ? 6
                    : volume == 6 ? 5
                    : volume == 5 ? 4
                    : volume == 4 ? 3
                    : volume == 3 ? 2
                    : volume == 2 ? 1
                    : 0;
        PlayerPrefs.SetInt("volume", volume);
    }

    public static void IncreaseVolume()
    {
        volume = volume == 0 ? 1
                    : volume == 1 ? 2
                    : volume == 2 ? 3
                    : volume == 3 ? 4
                    : volume == 4 ? 5
                    : volume == 5 ? 6
                    : volume == 6 ? 7
                    : volume == 7 ? 8
                    : volume == 8 ? 9
                    : 10;
        PlayerPrefs.SetInt("volume", volume);
    }
}
