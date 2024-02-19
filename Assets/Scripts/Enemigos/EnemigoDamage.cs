using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemigoDamage : MonoBehaviour
{

    private int vida = 10;

    private int puntos = 5;

    public int puntosTotal;

    public TextMeshProUGUI puntosText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida = vida - 1;

            if(vida <= 0)
            {

                puntosTotal = puntosTotal + puntos;

                puntosText.text = "Puntos: " + puntosTotal;

                Destroy(gameObject);
            }
        }


    }
}
