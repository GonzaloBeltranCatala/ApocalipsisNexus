using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Disparar : MonoBehaviour
{
    public Selector scriptSelector;
//pistola
    public GameObject prefab;

    public Transform insPoint;

     public TextMeshProUGUI municionPistolaText;

     public int municionPistola = 60;

//laser
    public GameObject prefabLaser;

    public TextMeshProUGUI municionText;

    public int municionLaser = 100;


//estacas
    
    public GameObject prefabEstaca;

     public TextMeshProUGUI municionEstacaText;

     public int municionEstaca = 10;
   

    private AudioSource sonido;

    public AudioClip clip;



    private int caja = 10;

    public AbrirTienda scriptTienda;

    public MenuPausa scriptPausa;

    public Salud scriptSalud;

    public Salvar scriptSalvar;


void Start()
{
    sonido = GetComponent<AudioSource>();
}

    private void OnDisparar()
    {

        if (scriptTienda.abrirTienda == false && scriptPausa.Pausa == false && scriptSalud.muerte == false && scriptSalvar.ganar == false)
        {
            if (scriptSelector.armas == 0)
            {
                if (municionPistola > 0)
                {

                    Instantiate(prefab, insPoint.position, insPoint.rotation);

                    municionPistola--;
                    municionPistola--;
                    municionPistolaText.text = municionPistola + "";
                }

            }

            if (scriptSelector.armas == 1)
            {
                if (municionLaser > 0)
                {
                  
                    Instantiate(prefabLaser, insPoint.position, insPoint.rotation);

                    municionLaser--;
                    municionText.text = municionLaser + "";
                }
            }

            if(scriptSelector.armas == 2){

                if (municionEstaca > 0)
                {

                    Instantiate(prefabEstaca, insPoint.position, insPoint.rotation);

                    municionEstaca--;
                    municionEstacaText.text = municionEstaca + "";
                }

            }

        }


    }
  

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Municion"))
        {
            if (scriptSelector.armas == 0)
            {
                sonido.PlayOneShot(clip);
                municionPistola = municionPistola + caja;
                municionPistolaText.text = municionPistola + "";

            }

            if (scriptSelector.armas == 1)
            {
                sonido.PlayOneShot(clip);
                municionLaser = municionLaser + caja;
                municionText.text = municionLaser + "";

            }

            if (scriptSelector.armas == 2)
            {
                sonido.PlayOneShot(clip);
                municionEstaca = municionEstaca + caja;
                municionEstacaText.text = municionEstaca + "";

            }

            
        }


    }
}
