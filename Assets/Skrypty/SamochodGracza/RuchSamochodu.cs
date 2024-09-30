using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchSamochodu : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rigidbody;

    private Vector3 input;
    private Predkosc PredkoscComponent;
    private Predkosc predkoscScript;
    private float predkoscPojazduGracza;
    private float procentPredkosc;

    void Start()
    {
        GameObject predkoscObject = GameObject.Find("PredkoscAlfa");
        PredkoscComponent = predkoscObject.GetComponent<Predkosc>();
    }

    private void Update()
    {
        predkoscScript = PredkoscComponent;
        predkoscPojazduGracza = predkoscScript.predkoscValue;
        procentPredkosc = predkoscPojazduGracza/150;
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        input = new Vector3(inputX, inputY, 0);
    }

    private void FixedUpdate()
    {
        Vector3 move = (input * moveSpeed * Time.fixedDeltaTime) * procentPredkosc * procentPredkosc;
        rigidbody.velocity = new Vector2(move.x, rigidbody.velocity.y);
    }
}