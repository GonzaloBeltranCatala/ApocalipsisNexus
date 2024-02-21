using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbrirTienda : MonoBehaviour
{

    public TextMeshProUGUI abrirText;

    public GameObject shop;

    public GameObject shopText;

    public bool abrirTienda = false;

    public bool botonE = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTienda()
    {
        if (abrirTienda == true)
        {
            if (botonE == false)
            {
                shop.SetActive(true);

                shopText.SetActive(false);

                botonE = true;

                Time.timeScale = 0f;

                Cursor.lockState = CursorLockMode.None;
            }
            else if(botonE == true)
            {
                shop.SetActive(false);

                shopText.SetActive(true);

                botonE = false;

                Time.timeScale = 1f;

                Cursor.lockState = CursorLockMode.Locked;
            }


           
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Tienda"))
        {
            shopText.SetActive(true);

            abrirTienda = true;
        }


    }

    private void OnTriggerExit(Collider collision)
    {
        shopText.SetActive(false);

        abrirTienda = false;
    }
}
