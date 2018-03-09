using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int score,col;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
        score = 0;
		col = 0;
        GetComponent<TextMesh>().text = " " + score;
		GameObject.Find ("GameOver").transform.position = new Vector3 (10, 2.9109f, 1.90039f);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<TextMesh>().text = " " + score;
		GameObject.Find ("Scoreover").GetComponent<TextMesh> ().text = "Score: " + score;


		if(Time.timeScale == 0)
			GameObject.Find ("GameOver").transform.position = new Vector3 (-1.1534f, 2.9109f, 1.90039f);
    }
}
