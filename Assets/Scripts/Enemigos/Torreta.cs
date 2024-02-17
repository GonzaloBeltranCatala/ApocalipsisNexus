using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotaci�n de la torreta

    void Update()
    {
        // Rotaci�n sobre el eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}
