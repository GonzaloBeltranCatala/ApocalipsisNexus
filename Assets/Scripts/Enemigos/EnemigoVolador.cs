using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVolador : MonoBehaviour
{
    public int rutina;
    public float Cronometro;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public bool atacando;

    // Start is called before the first frame update
    void Start()
    {
        
        target = GameObject.Find("Personaje");
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 8)
        {
            
            Cronometro += 1 * Time.deltaTime;
            if (Cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                Cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 2f);
                    transform.Translate(Vector3.forward * 3 * Time.deltaTime);
                    break;

            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
            {
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                
                transform.Translate(Vector3.forward * 4 * Time.deltaTime);

                
            }
            else
            {
                atacando = true;
            }
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }
}
