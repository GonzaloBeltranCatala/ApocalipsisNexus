using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderData;

public class StartGame : MonoBehaviour
{

    
    public void StartButton()
    {
        Time.timeScale = 1;

        // Carga la escena principal del juego
        SceneManager.LoadScene("Nivel01");

    }
}