using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referabs : MonoBehaviour
{
    public Transform obje;

    // Update is called once per frame
    void Update()
    {
        transform.position = obje.position;
    }
}
