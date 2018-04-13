using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

	public GameObject leftbat;
	public GameObject rigthbat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 1f, 0f);
        }
        else if (Input.GetKey (KeyCode.S))
        {
            leftbat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -1f, 0f);
        }
        
	}
}
