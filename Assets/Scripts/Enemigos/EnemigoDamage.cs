using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDamage : MonoBehaviour
{

    private int vida = 10;

    public Tienda scriptTienda;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida = vida - 1;

            if(vida <= 0)
            {
               
                scriptTienda.ActualizarPuntos();


                Destroy(gameObject);
            }
        }


    }
}
