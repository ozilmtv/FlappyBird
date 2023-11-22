using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    public float maximoTiempo = 1;
    public float Tiempo = 0;
    public GameObject ParedSpa;
    public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Tiempo > maximoTiempo)
        {
            GameObject newParedSpa = Instantiate(ParedSpa);
            newParedSpa.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newParedSpa,15);
            Tiempo = 0;
        }
        Tiempo += Time.deltaTime;
    }
}
