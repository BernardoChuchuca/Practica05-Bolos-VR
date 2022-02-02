using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAction : MonoBehaviour {
    
    public GameObject ball;
    public Transform cam;
    public float ballDistance = 2f;
    public float ballForce = 250f;
    bool holdingBall = true;
    Rigidbody ballRB;
	// Use this for initialization
	void Start () {
        ballRB = ball.GetComponent<Rigidbody>();
        ballRB.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(holdingBall ==true)
        
        if(Input.GetMouseButtonDown(0))
        {
            //GetComponent<Rigidbody>().AddForce(launchForce * transform.forward);
            holdingBall = false;
            ballRB.useGravity = true;
            ballRB.AddForce(cam.forward * ballForce);
        }
    }

    private void LateUpdate()
    {
        if (holdingBall == true)
        {
            ball.transform.position = cam.position + cam.forward * ballDistance;
        }
    }
}
