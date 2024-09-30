using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkt : MonoBehaviour
{
    [SerializeField] GameObject[] carPrefab;
    [SerializeField] string carTag = "auto1";

    public void SpawnPrefab()
    {
        var position = new Vector3(transform.position.x, transform.position.y);
        GameObject gameObject = Instantiate(carPrefab[Random.Range(0, carPrefab.Length)],
        position, Quaternion.identity);
        gameObject.tag = carTag;
        Destroy(gameObject, 15f);
    }
}
