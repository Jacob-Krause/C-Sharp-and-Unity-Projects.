using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float cameraSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dPosition = target.position + offset;
        Vector3 sPosition = Vector3.Lerp(transform.position, dPosition, cameraSpeed);
        transform.position = sPosition;

        transform.LookAt(target);
    }
}
