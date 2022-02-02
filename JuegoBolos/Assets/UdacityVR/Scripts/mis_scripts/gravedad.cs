using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 0.5f)
        {
            transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
        }
	}
}
