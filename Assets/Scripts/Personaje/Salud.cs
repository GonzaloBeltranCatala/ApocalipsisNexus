using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Salud : MonoBehaviour
{
    //public TextMeshProUGUI saludText;

    public Slider vidaText;

    private int salud = 100;

    public GameObject menuDerrota; // Objeto del men� de derrota

    private AudioSource sonido;

    public AudioClip clip;

    public bool muerte = false;



    public void Start()
    {
        menuDerrota.SetActive(false);

        sonido = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            salud -= 10;

            vidaText.value = salud;

           //saludText.text = "Salud: " + salud;

            if (salud <= 0)
            {
                // Implementar l�gica de muerte
                
                menuDerrota.SetActive(true); // Activar el objeto del men� de derrota
                
                muerte = true;

                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if(collision.CompareTag("Trampas")){

             menuDerrota.SetActive(true); // Activar el objeto del men� de derrota
                
                muerte = true;


                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

        }

        if (collision.CompareTag("Botiquin"))
        {
            sonido.PlayOneShot(clip);
            
            salud += 10;

            vidaText.value = salud;
        }

    }
}
