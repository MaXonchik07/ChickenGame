using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class run : MonoBehaviour
{
    public GameObject gameObject;
    public Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        vector3 = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        vector3 = new Vector3(transform.position.x+0.01f, transform.position.y+0.01f, transform.position.z+0.01f);
        transform.position = vector3;
    }
}
