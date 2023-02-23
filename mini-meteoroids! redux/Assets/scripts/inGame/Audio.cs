using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource explosion01;
    public AudioSource explosion02;
    public AudioSource explosion03;
    public AudioSource explosion04;
    public AudioSource explosion05;
    public AudioSource explosion06;
    public AudioSource explosion07;
    public AudioSource explosion08;
    public AudioSource explosion09;
    AudioSource chosen;
    int random;

    public void ExplosionAudio()
    {
        random = Random.Range(1, 10);
        chosen = random == 1 ? explosion01
            : random == 2 ? explosion02
            : random == 3 ? explosion03
            : random == 4 ? explosion04
            : random == 5 ? explosion05
            : random == 6 ? explosion06
            : random == 7 ? explosion07
            : random == 8 ? explosion08
            : explosion09;
        chosen.Play();
    }
}
