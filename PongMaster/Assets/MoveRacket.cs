using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        float speed = 30;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        if (Input.touchCount == 0)
            return;

        var deltaY = Input.GetTouch(0).deltaPosition.y;
        var newPos = new Vector2(rb.position.x, rb.position.y + (deltaY / 8));
        rb.MovePosition(newPos);
    }
}
