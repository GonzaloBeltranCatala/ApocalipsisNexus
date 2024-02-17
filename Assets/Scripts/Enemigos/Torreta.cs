using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación de la torreta

    void Update()
    {
        // Rotación sobre el eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}
