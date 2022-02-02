using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoverBolo : MonoBehaviour {

    private new Rigidbody rigidbody;
    public float speed = 10f;
    public int repeticiones = 2;
    public Text TXTScore;

	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        TXTScore.text = "Score: " + Puntuacion.score.ToString();
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        
        if(hor != 0.0f || ver != 0.0f) {
            Vector3 dir = transform.forward * ver + transform.right * hor;
            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }   
	}


    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Suma el puntaje");
        if(Puntuacion.score <= 50)
        {
            if (collision.gameObject.tag == "Pin")
            {
                Puntuacion.score = Puntuacion.score + 10;
                Destroy(collision.gameObject);
            }
            repeticiones = repeticiones - 1;
        }
        else
        {
            SceneManager.LoadScene("SalaDeBolos");
        }
        
    }

}
