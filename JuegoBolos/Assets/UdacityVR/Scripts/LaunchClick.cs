using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchClick : MonoBehaviour {
    public float launchForce = 1000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(launchForce * transform.forward);
        
    }
}
