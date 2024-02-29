using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderData;

public class StartGame : MonoBehaviour
{

    public GameObject cinematica1;
    public GameObject cinematica2;
    public GameObject cinematica3;
    
    public void StartButton()
    {

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