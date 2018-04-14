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
        if(Input.touchCount == 0) 
            return;
            
        var deltaY = Input.GetTouch(0).deltaPosition.y;
        var newPos = new Vector2(rb.position.x, rb.position.y + (deltaY/8));
        rb.MovePosition(newPos);
    }
}
