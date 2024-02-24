using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBala : MonoBehaviour
{

    public GameObject impacto;

    public Transform insPoint;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            Instantiate(impacto, insPoint.position, insPoint.rotation);

            Destroy(gameObject);
        }

        
    }


}
