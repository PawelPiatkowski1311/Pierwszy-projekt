using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WywolajDodaniePunktu : MonoBehaviour
{
    LiczeniePunktow punktyScript;
    void Start()
    {
        punktyScript = GameObject.Find("PunktyAlfa").GetComponent<LiczeniePunktow>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        punktyScript.DodajPunkt();
    }
}