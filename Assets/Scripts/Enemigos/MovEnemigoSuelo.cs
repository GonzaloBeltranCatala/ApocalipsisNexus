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

    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Personaje");
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 7)
        {
            ani.SetBool("Run", false);
            Cronometro += 1 * Time.deltaTime;
            if (Cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                Cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("Walk", false);
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 4f);
                    transform.Translate(Vector3.forward * 3 * Time.deltaTime);
                    ani.SetBool("Walk", true);
                    break;

            }
        }
        else
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
            ani.SetBool("Walk", false);
            ani.SetBool("Run", true);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
    }

    private void Update()
    {
        Comportamiento_Enemigo();
    }
}
