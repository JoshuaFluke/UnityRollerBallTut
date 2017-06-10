using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}


    private void FixedUpdate()
    {
        float strafe = Input.GetAxis("Horizontal");
        float forwardBackward = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(strafe, 0.0f, forwardBackward);

        rb.AddForce(movement * speed);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
