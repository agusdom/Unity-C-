using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBarra : MonoBehaviour
{
    public float velocidad = 0.4f;
           Vector3 posicionInicial;
    public ElementoInteractivo botonIzq;
    public ElementoInteractivo botonDer;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        float direccion;
        if(botonIzq.pulsado)
        {
            direccion = -1;
        }
        else if(botonDer.pulsado)
        {
            direccion = 1;
        }
        else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }
        float posicionX = transform.position.x + (direccion * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posicionX,-9,9),transform.position.y,transform.position.z);
    }
}
