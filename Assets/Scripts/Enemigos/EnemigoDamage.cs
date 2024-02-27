using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoDamage : MonoBehaviour
{
    public Slider vidaText;

    private int vida = 100;

    public Tienda scriptTienda;

   // public GameObject muerte;

    


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida = vida - 20;

            vidaText.value = vida;

            if (vida <= 0)
            {
                //Instantiate(muerte);

                scriptTienda.ActualizarPuntos();


                Destroy(gameObject);
            }
        }

        if (collision.CompareTag("Laser"))
        {
            vida = vida - 50;

            vidaText.value = vida;

            if (vida <= 0)
            {
               
                scriptTienda.ActualizarPuntos();


                Destroy(gameObject);
            }
        }



    }
}
