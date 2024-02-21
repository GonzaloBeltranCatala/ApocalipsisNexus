using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Disparar : MonoBehaviour
{
    public Selector scriptSelector;

    public GameObject prefab;

    public Transform insPoint;

    public TextMeshProUGUI municionPistolaText;

    public TextMeshProUGUI municionText;

    public int municionPistola = 60;

    public int municion = 200;

    private int caja = 10;


    private void OnDisparar()
    {

        if (scriptSelector.armas == 0)
        {
            if (municionPistola > 0)
            {

                //que voy a instanciar,donde, no rota
                Instantiate(prefab, insPoint.position, insPoint.rotation);

                municionPistola--;
                municionPistola--;
                municionPistolaText.text = municionPistola + "";
            }

        }

        if (scriptSelector.armas == 1)
        {
            if (municion > 0)
            {

                //que voy a instanciar,donde, no rota
                Instantiate(prefab, insPoint.position, insPoint.rotation);

                municion--;
                municion--;
                municionText.text = municion + "";
            }
        }





    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Municion"))
        {
            if (scriptSelector.armas == 0)
            {
                municionPistola = municionPistola + caja;
                municionPistolaText.text = municionPistola + "";

            }

            if (scriptSelector.armas == 1)
            {
                municion = municion + caja;
                municionText.text = municion + "";

            }

            
        }


    }
}
