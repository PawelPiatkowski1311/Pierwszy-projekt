using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float predkoscPojazdu1 = 140f;
    [SerializeField] private float predkoscPojazdu2 = 130f;
    [SerializeField] private float predkoscPojazdu3 = 90f;


    private Vector3 input;
    private float obrot;
    private float inputY = -500;
    private float predkoscOther;
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
        if (CompareTag("auto1"))
        {
            predkoscOther = predkoscPojazdu1;
        }
        else if (CompareTag("auto2"))
        {
            predkoscOther = predkoscPojazdu2;
        }
        else
        {
            predkoscOther = predkoscPojazdu3;
        }
        obrot = transform.rotation.z * -1000;
        input = new Vector3(obrot, inputY, 0);

    }
    private void FixedUpdate()
    {
        Vector3 move = input * (predkoscPojazduGracza - predkoscOther) * Time.fixedDeltaTime;
        rigidbody2D.velocity = new Vector2(move.x, move.y);
    }
}
