using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiczenieCzasu : MonoBehaviour
{
    public TextMeshProUGUI czasNaInterfejsie;
    public float licznik;
    public void Start()
    {
        licznik = 0f;
    }

    // Update is called once per frame
    public void Update()
    {
        licznik += Time.deltaTime;
        //czasNaInterfejsie.text = "CZAS: " + licznik.ToString("MM:SS.ff");
        var ts = System.TimeSpan.FromSeconds(licznik);
        czasNaInterfejsie.text = $"CZAS: {ts:mm\\:ss\\.ff}";
    }
}
