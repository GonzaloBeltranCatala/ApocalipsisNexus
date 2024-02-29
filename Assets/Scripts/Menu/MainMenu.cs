using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    private AudioSource sonido;

    public AudioClip clip;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }


    public void Menuprincipal()
    {
        sonido.PlayOneShot(clip);


        // Carga el menu principal del juego
        SceneManager.LoadScene("MenuPrincipal");

       


    }

    

}
