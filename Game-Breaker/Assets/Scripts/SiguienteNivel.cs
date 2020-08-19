using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string NivelACargar;
    public float retraso;
    
    [ContextMenu("ActivarCarga")]
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        if(!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(NivelACargar);
    }

    public bool EsUltimoNivel()
    {
        return NivelACargar == "Portada";
    }
}
