using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_control : MonoBehaviour {

    public GameObject Bar;
    private int speed_bar,flag,flag2;
    private int position_y;
    // Use this for initialization
    void Start () {
        speed_bar = 3;
        flag = 0;
        flag2 = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if(Score.col != 1)
        	transform.Translate(Vector3.left * speed_bar * Time.deltaTime);


        if (transform.position.x <= 3.5 && flag ==0)
        {
            Bar_Gen();
            flag = 1;
        }
        if (transform.position.x <= -4 && flag2 == 0)
        {
            Score.score += 1;
            GetComponent<AudioSource>().Play();
            flag2 = 1;
        }

        if (transform.position.x <= -5.5)
        {
            Destroy(gameObject);
        }
    }
    void Bar_Gen()
    {
        position_y = Random.Range(-1, 5);
        Instantiate(Bar, new Vector3(8, position_y, 0f), Quaternion.Euler(new Vector3(0, 0, 0)));
    }
}
