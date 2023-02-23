using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class whenDead : MonoBehaviour
{
    public BoxCollider2D shipCollider;
    public SpriteRenderer ship;

    public void dead()
    {
        PlayerPrefs.SetInt("NewScore", Scored.Score);
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }

    IEnumerator DisableShip()
    {
        yield return new WaitForSeconds(0.35f);
        ship.enabled = false;
        shipCollider.enabled = false;

    }
}
