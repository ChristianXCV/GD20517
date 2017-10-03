using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {

	public GameObject CUBO;
	public Vector3 movementAmount;
	Vector3 restart;

	// Use this for initialization
	void Start () {
		movementAmount = new Vector3 (1, -3, -1);

		restart = CUBO.transform.position;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			CUBO.transform.position += new Vector3 (1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			CUBO.transform.position += new Vector3 (-1, 0, 0);

		}
		if (Input.GetKeyDown (KeyCode.W)) {
			CUBO.transform.position += new Vector3 (0, 1, 0);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			CUBO.transform.position += new Vector3 (0, -1, 0);
		}



	}
}