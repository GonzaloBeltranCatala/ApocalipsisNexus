using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoDamage : MonoBehaviour
{
    public Slider vidaText;
    public Tienda scriptTienda;
    public Image imagenCanvas;
    public GameObject mirillaenemigo;
    public GameObject mirilla;

    public GameObject explosion;

    public GameObject congelado;

    public Transform insPoint;

    private int vida = 100;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            StartCoroutine(CambiarImagen());
            vida -= 15;
            vidaText.value = vida;
            

            if (vida <= 0)
            {
                
            Instantiate(explosion, insPoint.position, Quaternion.identity);


                scriptTienda.ActualizarPuntos();


                mirilla.SetActive(true);
                mirillaenemigo.SetActive(false);

                Destroy(gameObject,0.1f);
            }
        }

        if (collision.CompareTag("Laser"))
        {
            StartCoroutine(CambiarImagen());
            vida -= 35;
            vidaText.value = vida;
            

            if (vida <= 0)
            {
                Instantiate(explosion, insPoint.position, Quaternion.identity);

                scriptTienda.ActualizarPuntos();

                mirilla.SetActive(true);
                mirillaenemigo.SetActive(false);

                Destroy(gameObject,0.1f);
            }
        }

        if (collision.CompareTag("Estaca"))
        {
            StartCoroutine(CambiarImagen());
            vida -= 100;
            vidaText.value = vida;
            

            if (vida <= 0)
            {
                
                Instantiate(congelado, insPoint.position, Quaternion.identity);

                mirilla.SetActive(true);
                mirillaenemigo.SetActive(false);

                scriptTienda.ActualizarPuntos();
                Destroy(gameObject,0.1f);
            }
        }
    }

    IEnumerator CambiarImagen()
    {
        mirillaenemigo.SetActive(true);
        
        mirilla.SetActive(false);
        
        yield return new WaitForSeconds(0.5f); //duracion cambio
        mirilla.SetActive(true);
        
        mirillaenemigo.SetActive(false);
        

    }
}
