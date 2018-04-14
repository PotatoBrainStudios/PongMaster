using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour {

    int playerLeft = 0;
    int playerRight = 0;

    void OnCollisionEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "WallLeft")
        {
            playerRight += 1;
            Debug.Log("+1 right");
        }
        if (col.gameObject.name == "WallRight")
        {
            playerLeft += 1;
            Debug.Log("+1 left");
        }
    }
}
