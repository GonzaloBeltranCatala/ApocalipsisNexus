using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salud : MonoBehaviour
{
    public TextMeshProUGUI saludText;

    private int salud = 100;

    public GameObject menuDerrota; // Objeto del men� de derrota

    public void Start()
    {
        menuDerrota.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            salud -= 10;

            saludText.text = "Salud: " + salud;

            if (salud <= 0)
            {
                // Implementar l�gica de muerte
                
                menuDerrota.SetActive(true); // Activar el objeto del men� de derrota
                print("Perdiste");
                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
