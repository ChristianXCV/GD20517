using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phys1 : MonoBehaviour {

    Rigidbody rb;
    public float Doge;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * Doge);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * Doge);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Doge);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Doge);
        }
    }
}
