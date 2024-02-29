using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salvar : MonoBehaviour
{

    public GameObject salvarText;

    public GameObject victoria;
   
    public bool ganar = false;


    private void OnTienda()
    {
        if (salvarText.activeSelf)
        {
             victoria.SetActive(true);

            ganar = true;

            Cursor.lockState = CursorLockMode.None;

        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Hermano"))
        {
            salvarText.SetActive(true);

           
        }


    }

    private void OnTriggerExit(Collider collision)
    {
        salvarText.SetActive(false);

        
    }
}
