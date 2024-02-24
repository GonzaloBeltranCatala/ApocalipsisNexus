using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDamage : MonoBehaviour
{

    private int vida = 100;

    public Tienda scriptTienda;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida = vida - 20;

            if(vida <= 0)
            {
               
                scriptTienda.ActualizarPuntos();


                Destroy(gameObject);
            }
        }

        if (collision.CompareTag("Laser"))
        {
            vida = vida - 50;

            if(vida <= 0)
            {
               
                scriptTienda.ActualizarPuntos();


                Destroy(gameObject);
            }
        }



    }
}
