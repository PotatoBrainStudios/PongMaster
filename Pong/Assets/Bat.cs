using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour {
    public Rigidbody2D rb;

    public KeyCode upKey;
    public KeyCode downKey;
    public float speed = 10f;
    // Use this for initialization
    void Start () {
        //rb = GetComponent<Rigidbody2D>();
        
    }
    
    // Update is called once per frame
    void Update () {
        rb.velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(upKey))
        {
            rb.velocity = new Vector3(0f, 1f, 0f) * speed;
        }
        else if (Input.GetKey(downKey))
        {
            rb.velocity = new Vector3(0f, -1f, 0f) * speed;
        }

    }
}
