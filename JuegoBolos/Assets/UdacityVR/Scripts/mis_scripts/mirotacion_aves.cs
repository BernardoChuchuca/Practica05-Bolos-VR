using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirotacion_solar : MonoBehaviour {

    // Use this for initialization
    public Animator vueloAves;
    bool isPressed = false;
	void Start () {
        vueloAves.StartPlayback();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPressed == true) {
            vueloAves.StopPlayback();
        }
        if (Input.GetMouseButtonDown(0)) {
            ActivateAnimation();
        }
	}


    public void ActivateAnimation() {

        isPressed = true;
        vueloAves.SetBool("Volar",true);

    }
}
