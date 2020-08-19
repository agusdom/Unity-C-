using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int vidas = 3;
    public Text textoVidas;
    public MovimientoBarra barra;
    public MovimientoPelota pelota;
    public GameObject gameOver;
    public SiguienteNivel nextLevel;
    public SonidoFinPartida sonidoFinpartida;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorVidas();
    }

    // Update is called once per frame
    public void PerderVida()
    {
        if (vidas <= 0) return;
        Vidas.vidas--;
        ActualizarMarcadorVidas();

        if (vidas <= 0)
        {
            sonidoFinpartida.GameOver();
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            barra.enabled = false;

            nextLevel.NivelACargar = "Portada";
            nextLevel.ActivarCarga();
        }
        else
        {
            barra.Reset();
            pelota.Reset();
        }
        
    }

    void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }
}
