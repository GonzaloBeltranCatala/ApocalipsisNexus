using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{


    private AudioSource sonido;

    public AudioClip clip;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    public void ExitButton()
    {
        sonido.PlayOneShot(clip);

        // Cierra el juego
        Application.Quit();
    }
}


