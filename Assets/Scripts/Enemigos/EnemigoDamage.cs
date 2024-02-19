using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDamage : MonoBehaviour
{

    private int vida = 10;

    public int puntosTotal;

    public Tienda scriptTienda;


    private void Start()
    {
        scriptTienda = GameObject.Find("Tienda").GetComponent<Tienda>();
    }
    


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
