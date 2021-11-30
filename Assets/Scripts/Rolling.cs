using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody rb;

    //Use this for initialization 
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis ("Horizontal");
        float movementVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        rb.AddForce(movement * speed); 
    }
}
