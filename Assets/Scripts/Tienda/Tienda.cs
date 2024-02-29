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


     public GameObject arma02;

    public GameObject arma02Texto;

    public GameObject arma02Boton;

    public GameObject arma02Obtener;


    public GameObject textoObtener;

    private AudioSource sonido;

    public AudioClip clip;



    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarPuntos()
    {
        puntos = puntos + 5;
        puntosText.text = "" + puntos;
    }

    public void ComprarArma()
    {

        if(puntos >= 40 ){

            sonido.PlayOneShot(clip);

            //Instantiate(arma01, insPointArma.position, Quaternion.identity, padreArma).SetActive(false);

            //Instantiate(arma01, insPointArma.position, Quaternion.Euler(0,0,0), padreArma).SetActive(false);

            //Instantiate(arma01, padreArma, insPointArma ).SetActive(false);

            Instantiate(arma01, insPointArma.position, padreArma.rotation, padreArma).SetActive(false);

            arma01Texto.transform.SetParent(padreTexto);

        arma01Texto.SetActive(false);

        puntos = puntos - 40;

        puntosText.text = "" + puntos;


        arma01Boton.SetActive(false);
        
        arma01Obtener.SetActive(true);


        arma02Boton.SetActive(true);

        textoObtener.SetActive(false);


        }

    

    }


    public void ComprarArma02(){

         if(puntos >= 50 ){

            sonido.PlayOneShot(clip);

            //Instantiate(arma02, insPointArma.position, Quaternion.identity, padreArma).SetActive(false);

            //Instantiate(arma02, insPointArma.position, Quaternion.Euler(0,-83.15f,0), padreArma).SetActive(false);

            //Instantiate(arma01, padreArma, insPointArma ).SetActive(false);

            Instantiate(arma02, insPointArma.position, padreArma.rotation, padreArma).SetActive(false);

            //arma02.transform.Rotate(0, -90, 0);

            arma02Texto.transform.SetParent(padreTexto);

        arma02Texto.SetActive(false);

        puntos = puntos - 50;

        puntosText.text = "" + puntos;


        arma02Boton.SetActive(false);
        
        arma02Obtener.SetActive(true);


        }



    }



}
