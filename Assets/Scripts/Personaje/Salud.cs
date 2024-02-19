using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salud : MonoBehaviour
{

    public TextMeshProUGUI saludText;

    private int salud = 100;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            salud = salud - 10;

            saludText.text = "Salud: " + salud;


            if (salud <=0)
            {
                print("Perdiste");
            }
        }


    }
}
