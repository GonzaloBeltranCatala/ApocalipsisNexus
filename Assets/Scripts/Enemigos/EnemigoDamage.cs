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

    private int vida = 100;

    private void Start()
    {
        imagenCanvas.sprite = mirilla;  // volver a la imagen original 

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida -= 20;
            vidaText.value = vida;
            StartCoroutine(CambiarImagen());

            if (vida <= 0)
            {
                scriptTienda.ActualizarPuntos();
                Destroy(gameObject);
            }
        }

        if (collision.CompareTag("Laser"))
        {
            vida -= 75;
            vidaText.value = vida;
            StartCoroutine(CambiarImagen());

            if (vida <= 0)
            {
                scriptTienda.ActualizarPuntos();
                Destroy(gameObject);
            }
        }

        if (collision.CompareTag("Estaca"))
        {
            vida -= 30;
            vidaText.value = vida;
            StartCoroutine(CambiarImagen());

            if (vida <= 0)
            {
                scriptTienda.ActualizarPuntos();
                Destroy(gameObject);
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
