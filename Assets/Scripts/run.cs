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
    Transform fl;
    void Start()
    {
        d = GetComponent<Rigidbody2D>();
        fl = GetComponent<Transform>();
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
            fl.rotation = Quaternion.Euler(fl.rotation.eulerAngles.x+180, fl.rotation.eulerAngles.y, fl.rotation.eulerAngles.z);

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            Destroy(gameObject);
        }
    }
}


