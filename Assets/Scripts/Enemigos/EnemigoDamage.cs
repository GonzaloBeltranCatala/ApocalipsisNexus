using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoDamage : MonoBehaviour
{
    public Slider vidaText;
    public Tienda scriptTienda;
    public Image imagenCanvas;
    public Sprite mirillaenemigo;
    public Sprite mirilla;

    public GameObject explosion;

    public GameObject congelado;

    public Transform insPoint;

    private int vida = 100;

    private void Start()
    {
        imagenCanvas.sprite = mirilla;  // volver a la imagen original 

    }

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

                scriptTienda.ActualizarPuntos();
                Destroy(gameObject,0.1f);
            }
        }
    }

    IEnumerator CambiarImagen()
    {
        // Cambia la imagen del canvas durante un corto tiempo
        imagenCanvas.sprite = mirillaenemigo;
        yield return new WaitForSeconds(0.5f); //duracion cambio
        imagenCanvas.sprite = mirilla;  // volver a la imagen original 

    }
}
