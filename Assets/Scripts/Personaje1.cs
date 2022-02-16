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
        Debug.Log("Recive 7 de daño");
        Debug.Log("tu vida ahora es " + RecivirDaño(10,7));
        Debug.Log("Tu personaje se regenera");
        Debug.Log("tu vida nuevamente es " + Regeneracion(3, 7));

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
    int RecivirDaño(int vida, int daño)
    {
        return vida - daño;
    }
    int Regeneracion(int vida, int regen)
    {
        return vida + regen;
    }
}
