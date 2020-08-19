using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedToRestart : MonoBehaviour
{

    public GameObject FlapToRestart;
    public float delay = 1f;

    void OnEnable()
    {
        Invoke("EnableFlapToRestart", delay);
    }

    void EnableFlapToRestart()
    {
        FlapToRestart.SetActive(true);
    }
}
