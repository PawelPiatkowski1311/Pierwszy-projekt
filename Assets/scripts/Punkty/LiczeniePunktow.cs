using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiczeniePunktow : MonoBehaviour
{
    public TextMeshProUGUI punktyNaInterfejsie;
    public float punkty = 0;
    void Start()
    {
        punktyNaInterfejsie.text = "PUNKTY: " + punkty;
    }
    public void DodajPunkt()
    {
        punkty += 1;
        punktyNaInterfejsie.text = "PUNKTY: " + punkty;
    }
}
