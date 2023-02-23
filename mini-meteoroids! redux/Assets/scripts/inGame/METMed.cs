using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METMed : MonoBehaviour
{
    int random;
    SpriteRenderer spriteRenderer;
    public Sprite Med01;
    public Sprite Med02;
    public Sprite Med03;
    public Sprite Med04;
    public Sprite Med05;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Randomizer();
    }

    void Randomizer()
    {
        random = Random.Range(1, 6);
        spriteRenderer.sprite = random == 1 ? Med01
            : random == 2 ? Med02
            : random == 3 ? Med03
            : random == 4 ? Med04
            : Med05;
    }
}
