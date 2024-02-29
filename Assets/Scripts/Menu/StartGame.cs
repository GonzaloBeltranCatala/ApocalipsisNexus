using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public GameObject cinematica1;
    public GameObject cinematica2;
    public GameObject cinematica3;


    private AudioSource sonido;

    public AudioClip clip;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }


    public void StartButton()
    {
      
        sonido.PlayOneShot(clip);

        Time.timeScale = 1;

         StartCoroutine(Sequence());


    

    }


    private IEnumerator Sequence()
    {


        cinematica1.SetActive(true);

        yield return new WaitForSeconds(5);

        cinematica2.SetActive(true);

        yield return new WaitForSeconds(5);

        cinematica3.SetActive(true);

        yield return new WaitForSeconds(5);

        
        // Carga la escena principal del juego
        SceneManager.LoadScene("Nivel01");

        
    }
}