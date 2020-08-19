using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSistem : MonoBehaviour
{
    public static SoundSistem instance;
    public AudioClip AudioPoint;
    public AudioClip AudioHit;
    public AudioClip AudioFlap;
    public AudioSource Audiosource;

    private void Awake()
    {
        if(SoundSistem.instance == null)
        {
            SoundSistem.instance = this;
        }
        else if(SoundSistem.instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void PlayPoint()
    {
        PlayAudioClip(AudioPoint);
    }

    public void PlayFlap()
    {
        PlayAudioClip(AudioFlap);
    }

    public void PlayHit()
    {
        PlayAudioClip(AudioHit);
    }

    public void PlayAudioClip(AudioClip audioclip)
    {
        Audiosource.clip = audioclip;
        Audiosource.Play();
    }

    private void OnDestroy()
    {
        if(SoundSistem.instance == this)
        {
            SoundSistem.instance = null;
        }
    }

}
