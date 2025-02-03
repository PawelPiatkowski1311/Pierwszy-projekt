using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacjaAutostrady : MonoBehaviour
{
    [SerializeField] private Renderer bgRenderer;
    private Predkosc predkoscScript;
    private float predkoscPojazduGracza;
    private Predkosc PredkoscComponent;

    void Start()
    {
        GameObject predkoscObject = GameObject.Find("PredkoscAlfa");
        PredkoscComponent = predkoscObject.GetComponent<Predkosc>();
    }

    void Update()
    {
        predkoscScript = PredkoscComponent;
        predkoscPojazduGracza = predkoscScript.predkoscValue;
        bgRenderer.material.mainTextureOffset += new Vector2(0, predkoscPojazduGracza * 0.01f * Time.deltaTime);
    }
}
