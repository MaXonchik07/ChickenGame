using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnscaledParticle : MonoBehaviour
{
    private ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Time.timeScale < 0.01f) 
        {
            particle.Simulate(Time.unscaledDeltaTime, true, false); 
        }
    }
}
