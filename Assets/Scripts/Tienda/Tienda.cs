using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{

    public int puntos = 0;

    public TextMeshProUGUI puntosText;

    public GameObject arma01;

    public GameObject arma01Texto;

    public GameObject arma01Boton;

    public GameObject arma01Obtener;

    public Transform padreArma;

    public Transform padreTexto;

    public Transform insPointArma;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarPuntos()
    {
        puntos = puntos + 5;
        puntosText.text = "Puntos: " + puntos;
    }

    public void ComprarArma()
    {

        if(puntos >= 10 ){

            //Instantiate(arma01, insPointArma.position, Quaternion.identity, padreArma).SetActive(false);

            //Instantiate(arma01, insPointArma.position, Quaternion.Euler(0,0,0), padreArma).SetActive(false);

            //Instantiate(arma01, padreArma, insPointArma ).SetActive(false);

            Instantiate(arma01, insPointArma.position, padreArma.rotation, padreArma).SetActive(false);

            arma01Texto.transform.SetParent(padreTexto);

        arma01Texto.SetActive(false);

        puntos = puntos - 10;

        puntosText.text = "Puntos: " + puntos;


        arma01Boton.SetActive(false);
        
        arma01Obtener.SetActive(true);


        }

    

    }



}
