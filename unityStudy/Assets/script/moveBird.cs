﻿using UnityEngine;
using System.Collections;

public class MoveBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) == true)
			transform.Translate (Vector3.up * 0.2f);
		else
			transform.Translate (Vector3.down * 0.2f);
		switch ((int)transform.position.y) {
		case 8:
			transform.Translate (Vector3.down*0.2f);
			break;
		case -8:
			transform.Translate (Vector3.up*0.2f);
			break;
		default:
			break;	
		}
			
	}
}
