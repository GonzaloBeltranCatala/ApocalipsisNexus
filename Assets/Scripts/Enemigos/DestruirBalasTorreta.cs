using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBalasTorreta : MonoBehaviour
{
    public float lifetime = 2f; // Tiempo de vida del proyectil

    void Start()
    {
        // Destruir el proyectil después de un tiempo
        Destroy(gameObject, lifetime);
    }
}
