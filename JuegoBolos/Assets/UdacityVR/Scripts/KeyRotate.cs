using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour {
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rigtKey = KeyCode.D;
    public float rotSpeed = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(leftKey))
            transform.Rotate (0, -rotSpeed * Time.deltaTime, 0);

        if (Input.GetKey(rigtKey))
            transform.Rotate (0, -rotSpeed * Time.deltaTime, 0);



    }
}
