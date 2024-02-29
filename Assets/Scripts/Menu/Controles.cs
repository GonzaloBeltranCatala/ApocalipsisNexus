using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{

    public GameObject controlesImg;

    public GameObject botonAtras;


    private AudioSource sonido;

    public AudioClip clip;
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }


    public void pulsar()
    {
        sonido.PlayOneShot(clip);

        controlesImg.SetActive(true);

        botonAtras.SetActive(true);

    }

    public void atras()
    {
        sonido.PlayOneShot(clip);

        controlesImg.SetActive(false);

        botonAtras.SetActive(false);


    }
}
