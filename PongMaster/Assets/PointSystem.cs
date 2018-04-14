using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public Text leftText;
    public Text rightText;

    private int _leftCount;
    private int LeftCount
    {
        get { return _leftCount; }
        set
        {
            _leftCount = value;
            leftText.text = value.ToString();
        }
    }

    private int _rightCount;
    private int RightCount
    {
        get { return _rightCount; }
        set
        {
            _rightCount = value;
            rightText.text = value.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "WallLeft")
        {
            RightCount += 1;
            Debug.Log("+1 right");
        }
        if (col.gameObject.name == "WallRight")
        {
            LeftCount += 1;
            Debug.Log("+1 left");
        }
    }
}
