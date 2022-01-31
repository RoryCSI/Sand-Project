using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public Transform d;

    public float ForceStrength;
    float cap;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ForceStrength = 20;
            cap = 40f;
        }
        else
        {
            ForceStrength = 10;
            cap = 10f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(d.forward * ForceStrength);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-d.forward * ForceStrength);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-d.right * ForceStrength);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(d.right * ForceStrength);
        }

        if (Input.GetKey(KeyCode.R))
        {
            rb.velocity = Vector3.zero;
        }

        if (rb.velocity.magnitude >= cap)
        {
            rb.velocity = rb.velocity.normalized * cap;
        }
        
    }
}
