using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public CanvasGroup canvasgroup;
    public float SpeedFade;
    public string set;

    void Start()
    {
        canvasgroup.alpha = 1;
        set = "out";
    }
    void Update()
    {
        if(canvasgroup.alpha != 0 && set == "out")
        {
            canvasgroup.alpha -= SpeedFade * Time.deltaTime;
        }
        if(canvasgroup.alpha <= 0.9f && set == "in")
        {
            canvasgroup.alpha += SpeedFade * Time.deltaTime;
        }
    }
    public void FadeIn()
    {
        set = "in";
    }
}
