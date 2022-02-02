using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pino : MonoBehaviour {
    int contador;
    public Text puntuaion;
    public AudioSource sonpincaido;
    public int llave;

	// Use this for initialization
	void Start () {
        //sonpincaido = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    
public float speed;
    private void OnTriggerEnter(Collider pino)
    {
       if(pino.tag == "Player")
        {

            //sonpincaido.Play();
            Destroy(pino.gameObject);
            contador = contador + 10;
            puntuaion.text = "SCORE: " + contador;

            
            //ResetScene();
        }
        pino.tag = "Player";

    }



    


}
