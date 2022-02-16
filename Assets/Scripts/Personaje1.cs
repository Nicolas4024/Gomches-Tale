using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    public int vida = 10;
    public float velocidad;
    public Vector3 direccion;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Recive 7 de da�o");
        Debug.Log("tu vida ahora es " + RecivirDa�o(10,7));
        Debug.Log("Tu personaje se regenera");
        Debug.Log("tu vida nuevamente es " + Regeneracion(3, 7));

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
    int RecivirDa�o(int vida, int da�o)
    {
        return vida - da�o;
    }
    int Regeneracion(int vida, int regen)
    {
        return vida + regen;
    }
}
