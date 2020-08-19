using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoPelota : MonoBehaviour
{
    public float velocidadInicial = 600f;
    public Rigidbody rig;
           bool InGame = false;
           Vector3 posicionInicial;
    public Transform barra;
    public ElementoInteractivo pantalla;
    // Start is called before the first frame update

    private void Awake()
    {
        barra = transform.parent.GetComponent<Transform>();
    }
    void Start()
    {
        posicionInicial = transform.position;
    }

    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        InGame = false;
        DetenerMovimiento();
       
    }

    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(!InGame && (Input.GetButtonDown("Jump") || pantalla.pulsado))
        {
            InGame = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial,0));

        }
    }
}
