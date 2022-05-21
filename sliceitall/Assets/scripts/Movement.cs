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
    public void KnifeStartingPosition()
    {
        transform.position = new Vector3(-0, 1, -1);
        transform.eulerAngles = new Vector3(0, 180, 0);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    void TouchedFalse()
    {
        touched = false;
    }
}
