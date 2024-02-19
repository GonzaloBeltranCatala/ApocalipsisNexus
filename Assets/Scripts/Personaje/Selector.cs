using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Selector : MonoBehaviour
{

    public int armas = 0;

    public int armaPrevia;

    // Start is called before the first frame update
    void Start()
    {
        ArmaSeleccionada();
    }

    // Update is called once per frame
    void Update()
    {

        armaPrevia = armas;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if(armas >= transform.childCount - 1)
            {
                armas = 0;
            }
            else
            {
                armas++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (armas <= 0)
            {
                armas = transform.childCount - 1;
            }
            else
            {
                armas--;
            }
        }

        if (armaPrevia != armas)
        {
            ArmaSeleccionada();
        }

    }

    void ArmaSeleccionada()
    {
        int i = 0;
        foreach(Transform arma in transform)
        {
            if (i == armas)
            {
                arma.gameObject.SetActive(true);
            }
            else
            {
                arma.gameObject.SetActive(false);
            }

            i++;
        }
    }


}
