using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{

    public TextMeshProUGUI volumeText;
    public static float volume;
    public float sliderValue;

    public Slider volumeSlider;

    // Update is called once per frame
   void Update()
   {
        volume = PlayerPrefs.GetFloat("volume", 10);
        volumeSlider.value = volume;

        sliderValue = volumeSlider.value;
        volumeText.text = volume.ToString("00");
   }

   public void AudioSlider()
    {
        volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volume);
    }
}
