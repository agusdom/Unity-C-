using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject particulas;
    public Puntos puntos;

    private void OnCollisionEnter()
    {
        Instantiate(particulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPuntos();

    }
}
