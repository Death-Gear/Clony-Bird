using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Control : MonoBehaviour {

    public Vector3 jumpforce;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        jumpforce = new Vector3(0, 100, 0);
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) //Jump with touch
        {
			GetComponent<AudioSource>().Play();
            jumpforce = new Vector3(0, 250, 0);
            rb.velocity = Vector3.zero;
            rb.AddForce(jumpforce);
        }
        else
        {
            Physics.gravity = new Vector3(0, -15, 0); //Fall without touch
        }

	}

    IEnumerator OnCollisionEnter(Collision collision)
    {
		Score.col = 1;
		transform.eulerAngles = new Vector3 (0, 0, -50);
		Physics.gravity = new Vector3 (0, -30, 0);
		yield return new WaitForSeconds (1.5f);
        Time.timeScale = 0f;
        print("collision");
    }
}
