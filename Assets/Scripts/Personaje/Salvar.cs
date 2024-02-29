using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salvar : MonoBehaviour
{

    public GameObject salvarText;

   



    private void OnTienda()
    {
        if (salvarText.activeSelf)
        {
            print("ganaste");
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
