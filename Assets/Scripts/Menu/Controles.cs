using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{

    public GameObject controlesImg;

    public GameObject botonAtras;

    

    public void pulsar()
    {

        controlesImg.SetActive(true);

        botonAtras.SetActive(true);

    }

    public void atras()
    {
        controlesImg.SetActive(false);

        botonAtras.SetActive(false);


    }
}
