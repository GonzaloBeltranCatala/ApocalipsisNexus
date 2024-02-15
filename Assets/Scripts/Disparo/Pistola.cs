using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pistola : MonoBehaviour
{

    public GameObject prefab;

    public Transform insPoint;

    public TextMeshProUGUI municionText;

    public int municionPistola = 30;

    private int cajaPistola = 10;


    private void OnDisparar()
    {
        if (municionPistola > 0)
        {
           
            //que voy a instanciar,donde, no rota
            Instantiate(prefab, insPoint.position, insPoint.rotation);

            municionPistola--;
            municionPistola--;
            municionText.text = municionPistola + " / 60";

         
        }


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Municion"))
        {
            municionPistola = municionPistola + cajaPistola;
            municionText.text = municionPistola + " / 60";
        }


    }
}
