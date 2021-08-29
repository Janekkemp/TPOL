using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Transform cameraTarget;
    public float sSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;


    private void FixedUpdate()
    {
        Vector3 dpos = cameraTarget.position + dist;
        Vector3 spos = Vector3.Lerp(transform.position, dpos, sSpeed * Time.deltaTime);

        transform.position = spos;
        transform.LookAt(lookTarget.position);
    }
}
