using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosowanieKombinacji : MonoBehaviour
{
    //PredkoscAlfa predkoscScript;
    int wylosowanaKombinacja;
    float predkoscOdniesienie;
    float procentOdniesienie;
    Predkosc predkoscScript;
    Punkt punkt1;
    Punkt2 punkt2;
    Punkt3 punkt3;
    void Start()
    {
        predkoscScript = GameObject.Find("PredkoscAlfa").GetComponent<Predkosc>();
        punkt1 = GameObject.Find("Punkt1").GetComponent<Punkt>();
        punkt2 = GameObject.Find("Punkt2").GetComponent<Punkt2>();
        punkt3 = GameObject.Find("Punkt3").GetComponent<Punkt3>();
        StartCoroutine(RNG());
    }

    public IEnumerator RNG()
    {
        while(true)
        {
            predkoscOdniesienie = predkoscScript.predkoscValue;
            procentOdniesienie = predkoscOdniesienie/150;
            float randomWait = Random.Range(2.7f/Mathf.Pow(procentOdniesienie, 3f), 3.0f/Mathf.Pow(procentOdniesienie, 3f));
            yield return new WaitForSeconds(randomWait);
            obslugaKombinacji();
        }
    }
    void obslugaKombinacji()
    {
        wylosowanaKombinacja = Random.Range(1,7);
        if (wylosowanaKombinacja == 1)
        {
            punkt3.SpawnPrefab();
        }
        else if (wylosowanaKombinacja == 2)
        {
            StartCoroutine(punkt2.SpawnPrefab());
        }
        else if (wylosowanaKombinacja == 3)
        {
            punkt1.SpawnPrefab();
        }
        else if (wylosowanaKombinacja == 4)
        {
            punkt3.SpawnPrefab();
            StartCoroutine(punkt2.SpawnPrefab());
        }
        else if (wylosowanaKombinacja == 5)
        {
            punkt3.SpawnPrefab();
            punkt1.SpawnPrefab();
        }
        else if (wylosowanaKombinacja == 6)
        {
            StartCoroutine(punkt2.SpawnPrefab());
            punkt1.SpawnPrefab();
        }
        else
        {
            if (predkoscOdniesienie >= 200)
            {
                punkt3.SpawnPrefab();
                StartCoroutine(punkt2.SpawnPrefab());
                punkt1.SpawnPrefab();
            }
            else
            {
                obslugaKombinacji();
            }
        }
    }
}
