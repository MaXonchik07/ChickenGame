using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMoving : MonoBehaviour
{
    public float levelSpeed;
    public float end;
    void FixedUpdate()
    {
        if (transform.position.x >= end)
        {
            transform.Translate(Vector2.left * Time.deltaTime * levelSpeed);
        }
        else
        {
            
        }
    }
}
