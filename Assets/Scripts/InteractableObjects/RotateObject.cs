using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float xRot;
    public float yRot;
    public float zRot;
    public bool canRotate;

    void Update()
    {
        if(canRotate)
            transform.Rotate(xRot * Time.deltaTime, yRot * Time.deltaTime, zRot * Time.deltaTime);
    }

    public void AllowRotation()
    {
        canRotate = !canRotate;
    }
}
