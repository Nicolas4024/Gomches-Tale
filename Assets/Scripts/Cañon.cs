using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject disparo;

    // Start is called before the first frame update
    void Start()
    {
        CrearBala();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CrearBala() 
    {
        Instantiate(disparo);

    }
}
