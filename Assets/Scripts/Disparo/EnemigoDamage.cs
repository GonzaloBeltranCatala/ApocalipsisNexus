using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemigoDamage : MonoBehaviour
{

    private int vida = 10;

    private int puntos = 5;

    public TextMeshProUGUI puntosText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida = vida - 1;

            if(vida <= 0)
            {
                puntosText.text = "Puntos: " + puntos;

                Destroy(gameObject);
            }
        }


    }
}
