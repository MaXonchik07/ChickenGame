using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMoving : MonoBehaviour
{
    public float levelSpeed;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * levelSpeed);
    }
}
