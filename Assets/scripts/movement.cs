using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float mainthrust=100f;
    public float rotationthrust = 100f;



    Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainthrust * Time.deltaTime);
        }
        
    }
    void ProcessRotate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            ApllyRotation(rotationthrust);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            ApllyRotation(-rotationthrust);
        }
    }

    private void ApllyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
