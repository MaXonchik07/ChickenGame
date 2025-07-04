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
        if (transform.position.x <= 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 2);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            d.gravityScale = -d.gravityScale;
            if (d.gravityScale == -5)
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


