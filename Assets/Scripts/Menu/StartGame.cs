using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderData;

public class StartGame : MonoBehaviour
{
   

    public void StartButton()
    {
        // Carga la escena principal del juego
        SceneManager.LoadScene("Nivel01");

    }
}