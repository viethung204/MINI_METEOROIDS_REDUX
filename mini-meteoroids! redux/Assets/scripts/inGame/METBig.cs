using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METBig : MonoBehaviour
{
    int random;
    SpriteRenderer spriteRenderer;
    public Sprite Big01;
    public Sprite Big02;
    public Sprite Big03;
    public Sprite Big04;
    public Sprite Big05;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Randomizer();
    }

    void Randomizer()
    {
        random = Random.Range(1, 6);
        spriteRenderer.sprite = random == 1 ? Big01
            : random == 2 ? Big02
            : random == 3 ? Big03
            : random == 4 ? Big04
            : Big05;
    }
}
