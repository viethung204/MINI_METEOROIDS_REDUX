using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METSmall : MonoBehaviour
{
    int random;
    SpriteRenderer spriteRenderer;
    public Sprite Small01;
    public Sprite Small02;
    public Sprite Small03;
    public Sprite Small04;
    public Sprite Small05;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Randomizer();
    }

    void Randomizer()
    {
        random = Random.Range(1, 6);
        spriteRenderer.sprite = random == 1 ? Small01
            : random == 2 ? Small02
            : random == 3 ? Small03
            : random == 4 ? Small04
            : Small05;
    }
}
