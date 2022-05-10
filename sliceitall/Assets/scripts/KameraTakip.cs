using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public float smoothSpeed;
    public Transform playerTransform;
    private void Start()
    {
        playerTransform = FindObjectOfType<Movement>().transform;
    }
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            Vector3 desiredPosition = new Vector3(transform.position.x + 1f, playerTransform.position.y + 3.3f, playerTransform.position.z - 14f);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        else
        {
            playerTransform = FindObjectOfType<Movement>().transform;
        }

    }
}
