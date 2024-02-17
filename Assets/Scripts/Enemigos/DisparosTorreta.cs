using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosTorreta : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField]
    private float _timer = 2f;
    private float timerCount = 0f;

    [SerializeField]
    private int _counter;
    private int _maxCounter = 20;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireBullets());    
    }

    // Update is called once per frame
    void Update()
    {/*
       timerCount += Time.deltatime;
       if(timerCount>timer)
       {
            Instantiate(bullet, transform.position, transform.rotation);
            timerCount = 0f;
       }*/
    }
    


    IEnumerator FireBullets()
    {
        Debug.Log("Inicio coroutine");
        for(int i=0; i < _maxCounter; i++)
        {
            _counter++;
            Instantiate(bullet, transform.position, transform.rotation);
            yield return new WaitForSeconds(_timer);
        }
        Debug.Log("Fin coroutine");

    }
}
