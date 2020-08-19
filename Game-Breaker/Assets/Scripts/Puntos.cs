using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;
    public GameObject levelCompleted;
    public GameObject gameCompleted;
    public SiguienteNivel nextLevel;
    public MovimientoPelota pelota;
    public MovimientoBarra barra;
    public Transform contenedorBloques;
    public SonidoFinPartida sonidoFinpartida;
    // Start is called before the first frame update

    void Start()
    {
        ActualizarMarcadorPuntos();
    }

    public void GanarPuntos()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            barra.enabled = false;

            if (nextLevel.EsUltimoNivel())
            {
                gameCompleted.SetActive(true);
            }
            else
            {
                levelCompleted.SetActive(true);
            }

            sonidoFinpartida.LevelComplete();
            nextLevel.ActivarCarga();
        }
    }

    void ActualizarMarcadorPuntos()
        {
            textoPuntos.text = "Puntos: " + Puntos.puntos;
        }


    
}
