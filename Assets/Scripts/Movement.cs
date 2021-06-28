using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float mainThrust = 100f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThurst();
        ProcessRotation();
    }


    void ProcessThurst()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }        

    }


    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating left");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating right");
        }
    }
}
