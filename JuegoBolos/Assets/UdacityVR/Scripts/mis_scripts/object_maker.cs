using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_maker : MonoBehaviour {

    // Use this for initialization

    public GameObject objetoAcrear;
	void Start () {
        for (int i=0; i<= 20; i++)
        {
            object_maker.Instantiate(objetoAcrear, new Vector3(0+i, 1, 2), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
