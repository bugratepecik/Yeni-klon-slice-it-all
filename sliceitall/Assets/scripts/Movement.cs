using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    bool touched;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            touched = true;
            rb.isKinematic = false;
            rb.velocity = new Vector3(5, 7, 0);
            rb.angularVelocity = new Vector3(0, 0, -7f);
        }
        if (touched)
        {
            rb.isKinematic = false;
            Invoke("TouchedFalse", 0.1f);
        }
    }
    void TouchedFalse()
    {
        touched = false;
    }
}
