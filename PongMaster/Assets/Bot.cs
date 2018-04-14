using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour {
    Transform bar;

	// Use this for initialization
	void Start () {
        bar = GameObject.Find("Ball").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, bar.position.y);
	}
}
