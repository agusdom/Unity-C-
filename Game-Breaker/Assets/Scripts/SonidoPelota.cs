using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPelota : MonoBehaviour
{

    public AudioSource puntos;
    public AudioSource rebotes;
    public AudioSource fallos;


    void OnCollisionEnter(Collision otro)
    {
        if(otro.gameObject.CompareTag("Bloque"))
        {
            puntos.Play();
        }
        else
        {
            rebotes.Play();
        }
    }

    void OnTriggerEnter(Collider caida)
    {
        if (caida.tag == "Suelo")
        {
            fallos.Play();
        }
    }


}
