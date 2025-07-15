using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print("efefefefe");
        if (other.CompareTag("Player"))
        {
            run booster = other.GetComponent<run>();
        }
    }
}
