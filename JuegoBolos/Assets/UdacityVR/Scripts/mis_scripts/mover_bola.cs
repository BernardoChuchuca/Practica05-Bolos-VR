using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;public class mover_bola : MonoBehaviour
{    private new Rigidbody rigidbody;    public float speed = 10f;    

    void Start()
    {        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {                float hor = Input.GetAxisRaw("Horizontal");        float ver = Input.GetAxisRaw("Vertical");

        if (hor != 0.0f || ver != 0.0f)
        {            Vector3 dir = transform.forward * ver + transform.right * hor;            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);        }
    }    }
