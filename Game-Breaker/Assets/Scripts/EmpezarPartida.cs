using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
    public ElementoInteractivo pantalla;

    void Update()
    {
        if(Input.GetButtonDown("Jump") || pantalla.pulsado)
        {
            Vidas.vidas = 3;
            Puntos.puntos = 0;
            SceneManager.LoadScene("Nivel1");
        }
    }
}
