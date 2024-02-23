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

       // Instantiate(arma01, insPointArma.position, Quaternion.identity, padreArma).SetActive(false);

        Instantiate(arma01, insPointArma.position, Quaternion.Euler(84.265f,0,0), padreArma).SetActive(false);

        arma01Texto.transform.SetParent(padreTexto);

        arma01Texto.SetActive(false);



    }



}
