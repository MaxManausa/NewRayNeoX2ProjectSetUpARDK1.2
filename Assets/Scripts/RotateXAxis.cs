using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateXAxis: MonoBehaviour
{
    public float rotationSpeed = 10f; // Speed of rotation in degrees per second

    private void Update()
    {
        // Rotate the object continuously on the Y-axis
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
