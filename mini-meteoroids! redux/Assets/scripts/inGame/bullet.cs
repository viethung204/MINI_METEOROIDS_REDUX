using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
