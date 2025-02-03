using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkt2 : MonoBehaviour
{
    [SerializeField] GameObject[] carPrefab;
    [SerializeField] string carTag = "auto2";

    public IEnumerator SpawnPrefab()
    {
        var randomSpawn = Random.Range(0.0f,1.0f);
        yield return new WaitForSeconds(randomSpawn);
        var position = new Vector3(transform.position.x, transform.position.y);
        GameObject gameObject = Instantiate(carPrefab[Random.Range(0, carPrefab.Length)],
        position, Quaternion.identity);
        gameObject.tag = carTag;
        Destroy(gameObject, 15f);
    }
}
