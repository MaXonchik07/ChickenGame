using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class SoundVolume : MonoBehaviour
{
    public float Volume;
    public AudioSource MusicOF;
    public bool MusicOn = true;

    void Update()
    {
        if (MusicOn == true)
        {
            AudioListener.volume = Volume;
        }
        else if (MusicOn == false)
        {
            MusicOF.mute = true;
        }
    }
}
