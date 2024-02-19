using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tienda : MonoBehaviour
{

    public int puntos = 0;

    public TextMeshProUGUI puntosText;

   

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


}
