using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {

	public GameObject CUBO; //
	public Vector3 movementAmount; // used for 3D positions and directions
	Vector3 restart;

	// Use this for initialization
	void Start () {
		movementAmount = new Vector3 (1, -3, -1); 
        //Hi
		restart = CUBO.transform.position;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) { //input - read axes setup input manager. keycode - they allow what you assigned
            //it to function
			CUBO.transform.position += new Vector3 (1, 0, 0); //move right
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			CUBO.transform.position += new Vector3 (-1, 0, 0); //move left

		}
		if (Input.GetKeyDown (KeyCode.W)) {
			CUBO.transform.position += new Vector3 (0, 1, 0); //move up
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			CUBO.transform.position += new Vector3 (0, -1, 0); //move down
		}



	}
}