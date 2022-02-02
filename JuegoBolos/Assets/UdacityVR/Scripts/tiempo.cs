using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tiempo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lugar();

    }


    public Scene scene;
    public float inicio = 0;
    public float fin = 0;
    public void lugar()
    {
        inicio += Time.deltaTime;
        if (inicio >= fin)
        {
            Debug.Log("'SignPost.ResetScene()' was called");

            // TODO: Reset the scene by getting a reference to the scene and reloading it
            // Declare a Scene named 'scene', then use SceneManager.GetActiveScene () to get the current scene and assign it to 'scene'
            // Use SceneManager.LoadScene() and the Scene.name property to reload the scene
            scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
