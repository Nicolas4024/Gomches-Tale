using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEscala : MonoBehaviour
{
    public float escala = 2f;
    public float velocidad = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(escala, escala, escala);
        transform.position += new Vector3(velocidad, 0, 0);
    }
}
