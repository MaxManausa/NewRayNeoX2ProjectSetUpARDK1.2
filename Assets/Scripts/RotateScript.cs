using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour

{
    public bool rotateOnPosX = false;
    public bool rotateOnNegX = false;
    public bool rotateOnPosY = false;
    public bool rotateOnNegY = false;
    public bool rotateOnPosZ = false;
    public bool rotateOnNegZ = false;

    public float rotationSpeed = 50.0f; // Rotation speed in degrees per second

    void Start()
    {
       
    }

    void Update()
    {
        if (rotateOnPosX) RotateOnPosX();
        if (rotateOnNegX) RotateOnNegX();
        if (rotateOnPosY) RotateOnPosY();
        if (rotateOnNegY) RotateOnNegY();
        if (rotateOnPosZ) RotateOnPosZ();
        if (rotateOnNegZ) RotateOnNegZ();
    }

    void RotateOnPosX()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }

    void RotateOnNegX()
    {
        transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
    }

    void RotateOnPosY()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    void RotateOnNegY()
    {
        transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    void RotateOnPosZ()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    void RotateOnNegZ()
    {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
}


