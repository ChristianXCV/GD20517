using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserII : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(beam.origin, beam.direction * 1000f);

        RaycastHit beamHit = new RaycastHit();

        if (Physics.Raycast (beam, out beamHit, 1000f))
        {
            Debug.Log("you hit something");
            if (Input.GetMouseButton (0)) {
                Destroy(beamHit.collider.gameObject);
                beamHit.rigidbody.AddForce(/*Vector3.up * 1000f*/ Random.insideUnitSphere * 5000f);
            }
            if (Input.GetMouseButton(2)) {
                Destroy(beamHit.collider.gameObject);
            }
        }
		
	}
}
