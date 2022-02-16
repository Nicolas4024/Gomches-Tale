using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : MonoBehaviour
{
    public float velocidadMovement = 0.0001f;
    public float scale = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3 (scale, scale, scale);
        transform.position += new Vector3 (velocidadMovement, 0, 0);
    }
}
