using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Vector3 movement = h * transform.right / 5 + v * transform.forward / 5;
		GetComponent<Rigidbody> ().MovePosition (transform.position + movement);

		float mag = movement.magnitude;
		if (mag > 0.01) {
			GetComponent<Animator>().SetBool("isWalking", true);
		} else {
			GetComponent<Animator> ().SetBool ("isWalking", false);
		}

		float mouseInput = Input.GetAxis ("Mouse X");
		Vector3 lookhere = new Vector3 (0, mouseInput * 2 , 0);
		transform.Rotate (lookhere);
	}
}
