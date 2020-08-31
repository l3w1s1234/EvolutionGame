using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 myPos;
    public Transform target;
    public float smoothSpeed = 0.3f;

    // Update is called once per frame
    void Update()
    {

        Vector3 desiredPosition = target.position + myPos;
        Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPostion;
    }
}
