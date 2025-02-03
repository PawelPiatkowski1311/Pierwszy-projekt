using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothRotateObject : MonoBehaviour
{
    [SerializeField] public float rotationSpeed = 100.0f; // Prędkość obrotu
    [SerializeField] public float maxRotationAngle = 30f; // Maksymalny kąt obrotu w stopniach
    private Vector3 input;

    void Update()
    {
        float input = Input.GetAxis("Horizontal") * maxRotationAngle;
        Quaternion target = Quaternion.Euler(0, 0, -input);
        // Płynny obrót
        transform.rotation = Quaternion.Slerp(transform.rotation, target, rotationSpeed * Time.deltaTime);
    }
}
