using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class run : MonoBehaviour
{
    Rigidbody2D d;
    SpriteRenderer fl;
    void Start()
    {
        d = GetComponent<Rigidbody2D>();
        fl = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        transform.position += new Vector3(0.05f, 0, 0);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            d.gravityScale *= -1;
            if (d.gravityScale == -20)
            {
                fl.flipY = true;
            }
            else
            {
                fl.flipY = false;
            }
            
        }
    }
}

