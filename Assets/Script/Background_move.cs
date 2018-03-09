using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_move : MonoBehaviour {

    public float speed_background;

	// Use this for initialization
	void Start () {
        speed_background = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Score.col != 1)
        	transform.Translate(Vector3.left * speed_background * Time.deltaTime);

        if(transform.localPosition.x<=-9.5)
            transform.localPosition += new Vector3(2*(12.19f-0), 0, 0);
	}
}
