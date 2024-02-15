using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunicionPistola : MonoBehaviour
{
  
    void OnTriggerEnter(Collider collision)
    {

        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

}
