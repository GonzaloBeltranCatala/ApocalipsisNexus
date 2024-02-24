using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Disparar : MonoBehaviour
{
    public Selector scriptSelector;

    public GameObject prefab;

    public GameObject prefabLaser;

    public Transform insPoint;

    public TextMeshProUGUI municionPistolaText;

    public TextMeshProUGUI municionText;

    public int municionPistola = 60;

    public int municionLaser = 10;

    private int caja = 10;

    public AbrirTienda scriptTienda;


    private Vector2 moveInput;


    private void OnDisparar()
    {

        if (scriptTienda.abrirTienda == false)
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

        }


    }
  
      
    private void OnDispararHold(){

            if (scriptSelector.armas == 1)
            {
                if (municionLaser > 0)
                {

                    //que voy a instanciar,donde, no rota
                    Instantiate(prefabLaser, insPoint.position, insPoint.rotation);

                    municionLaser--;
                    municionText.text = municionLaser + "";
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
                municionLaser = municionLaser + caja;
                municionText.text = municionLaser + "";

            }

            
        }


    }
}
