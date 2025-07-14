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
using UnityEngine.XR;

public class run : MonoBehaviour
{
    Rigidbody2D rigid;
    Transform transf;
    public float movetimer = 3;
    public float cdTime = 0.25f;
    private float timer;
    private float lastFlipTime = 0;
    public float test;
    public float speed = 3;
    public string ChickenName;
    public GameObject effect;
    private bool onGround = false;
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
        Vector2 screenPos = Camera.main.WorldToViewportPoint(transform.position);
        if ((screenPos.x < 0 || screenPos.y > 1 || screenPos.y < 0) && timer >= movetimer)
        {
            Destroy(gameObject);
            Instantiate(effect, transform.position, quaternion.identity);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            Destroy(gameObject);
            Instantiate(effect, transform.position, quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
    public void ToDest()
    {
        Destroy(gameObject);
    }
    public void jumpButton()
    {
        if (onGround == true)
        {
            lastFlipTime = timer;
            rigid.gravityScale = -rigid.gravityScale;
            transf.rotation = Quaternion.Euler(transf.rotation.eulerAngles.x + 180, transf.rotation.eulerAngles.y, transf.rotation.eulerAngles.z);
        }
    }
}


