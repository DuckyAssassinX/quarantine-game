using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Awake()
    {
        offset = new Vector3(0.0f,6.0f, -10.0f);
    }

    private void Update()
    {
        if (target == null)
        {
            print("target was null");
            return;
        }

        Vector3 newPos = target.position + offset;

        //newPos.z = offset.z;
        newPos.y = offset.y;

        transform.position = newPos;
    }
}
