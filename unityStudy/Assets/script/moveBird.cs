﻿using UnityEngine;
using System.Collections;

public class MoveBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) == true)
			transform.Translate (Vector3.up * 0.1f);
		else
			transform.Translate (Vector3.down * 0.1f);
		switch ((int)transform.position.y) {
		case 8:
			transform.Translate (Vector3.down*0.1f);
			break;
		case -8:
			transform.Translate (Vector3.up*0.1f);
			break;
		default:
			break;	
		}
			
	}
}
