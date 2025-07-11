using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx; //звук при наведении
    public AudioClip clickFx; //звук при нажатии

    public void HoverSound() // при наведении воспроизвести единожды
    {
        myFx.PlayOneShot(hoverFx);
    }
        public void ClickSound() // при клике воспроизвести единожды
    {
        myFx.PlayOneShot(clickFx);
    }
}
