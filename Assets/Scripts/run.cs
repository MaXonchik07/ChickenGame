using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using TMPro;
using Unity.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class run : MonoBehaviour
{
    Rigidbody2D rigid;
    Transform transf;
    public float movetimer = 3;
    public float cdTime = 0.5f;
    private float timer;
    private float lastFlipTime = 0;
    public float test;
    public float speed = 3;
    public GameObject effect;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        transf = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer <= movetimer)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            Destroy(gameObject);
            Instantiate(effect, transform.position, quaternion.identity);
        }
    }
    public void jumpButton()
    {
        if (timer >= lastFlipTime + cdTime)
        {
            lastFlipTime = timer;
            rigid.gravityScale = -rigid.gravityScale;
            transf.rotation = Quaternion.Euler(transf.rotation.eulerAngles.x + 180, transf.rotation.eulerAngles.y, transf.rotation.eulerAngles.z);
        }
    }
}


