using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class DisparosTorreta : MonoBehaviour
{
    public Transform playerTransform; // Transform del jugador
    public GameObject projectilePrefab; // Prefab del proyectil 
    public float fireRate = 1f; // Frecuencia de disparo
    public float range = 10f; // Alcance de detección
    public LineRenderer lineRenderer; // Línea de disparo
    private float timeToFire = 0f;

    public float force = 100f; // Fuerza aplicada a la bala

    void Start()
    {
        // Obtener el componente Rigidbody
        Rigidbody rb = GetComponent<Rigidbody>();

        // Aplicar una fuerza en la dirección forward
        rb.AddForce(transform.forward * force);
    }

    void Update()
    {
        // Detección del jugador
        Vector3 directionToPlayer = playerTransform.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;
        if (distanceToPlayer <= range)
        {
            // Rotar hacia el jugador
            transform.LookAt(playerTransform);

            // Actualizar la línea de disparo
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, playerTransform.position);

            // Disparar si ha pasado el tiempo de espera
            if (Time.time >= timeToFire)
            {
                timeToFire = Time.time + 1f / fireRate;
                ShootProjectile();
            }
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }

    void ShootProjectile()
    {
        // Instanciar el proyectil (rayo)
        Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation);
    }
}
