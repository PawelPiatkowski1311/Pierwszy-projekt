using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Predkosc : MonoBehaviour
{
    public float predkoscValue = 150; // Poprawiona nazwa zmiennej
    public TextMeshProUGUI predkoscNaInterfejsie;

    void Start()
    {
        StartCoroutine(przyspieszenie());
    }

    void Update()
    {
        predkoscNaInterfejsie.text = "PREDKOSC: " + predkoscValue + " km/h";
    }

    IEnumerator przyspieszenie()
    {
        while (predkoscValue <= 256)
        {
            yield return new WaitForSeconds(3);
            predkoscValue += 1;
        }
    }
}
