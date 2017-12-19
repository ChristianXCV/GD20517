using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{

    // Use this for initialization
    public GameObject[] prefab;
    int selectionBuilding = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(beam.origin, beam.direction * 1000f);

        RaycastHit beamHit = new RaycastHit();

        if (Input.anyKeyDown)
        {
            if (selectionBuilding < prefab.Length - 1)

            {
                selectionBuilding++; 
                    } else
            {
                selectionBuilding = 0;
            }
        }


        if (Physics.Raycast(beam, out beamHit, 1000f))
        {
            
            if (Input.GetMouseButton(0))
            {
                Debug.Log("you hit something");
                if (beamHit.collider.gameObject.tag == "building location")
                Instantiate(prefab[selectionBuilding], beamHit.collider.gameObject.transform.position, Quaternion.identity); //instantiate(spawn) our prefab at spawnPoint.position   
            }
        }

    }
}
