using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolizja : MonoBehaviour
{
    FadeOut fadeInScript;

    void Start()
    {
        fadeInScript = GameObject.Find("FadeInOut").GetComponent<FadeOut>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "AutoGracza")
        {
            fadeInScript.FadeIn();
        }
    }
}
