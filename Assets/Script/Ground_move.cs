﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_move : MonoBehaviour {

    public float speed_ground;

    // Use this for initialization
    void Start () {
        speed_ground = 3.0f;
    }
	
	// Update is called once per frame
	void Update () {
		if(Score.col != 1)
        	transform.Translate(Vector3.left * speed_ground * Time.deltaTime);

        if (transform.localPosition.x <= -9.05)
            transform.localPosition += new Vector3(2 * (12.19f - 0), 0, 0);
    }
}
