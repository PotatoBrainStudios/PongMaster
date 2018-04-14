using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";

    private Vector3 firstTouchPos;   //First touch position
    private Vector3 lastTouchPos;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered

    void Start()
    {
        dragDistance = Screen.height/100 * 5;
    }
    void FixedUpdate()
    {
        // float v = Input.GetAxisRaw(axis);
        // GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                firstTouchPos = touch.position;
                lastTouchPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lastTouchPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lastTouchPos = touch.position;  //last touch position. Ommitted if you use list

                if (Mathf.Abs(lastTouchPos.y - firstTouchPos.y) > dragDistance)
                {//It's a drag
                    if (lastTouchPos.y > firstTouchPos.y)  //If the movement was up
                    {   //Up swipe
                        Debug.Log("Up Swipe");
                        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
                    }
                    else
                    {   //Down swipe
                        Debug.Log("Down Swipe");
                        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

                    }
                }
            }
            else {
                // It's a t(r)ap!
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
    }
}
