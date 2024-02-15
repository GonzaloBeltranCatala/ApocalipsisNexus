using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigoSuelo : MonoBehaviour
{
    public int rutina;
    public float Cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    public void Comportamiento_Enemigo()
    {
        Cronometro += 1 * Time.deltaTime;
    }
}
