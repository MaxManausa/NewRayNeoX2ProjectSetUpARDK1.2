using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCubeRotator : MonoBehaviour
{
    [SerializeField] private float amplitude = 1.0f; // Amplitude of sinusoidal motion
    [SerializeField] private float speed = 1.0f; // Speed of the sinusoidal motion
    [SerializeField] private float rotationSpeed = 30.0f; // Speed of the rotation around the Y-Axis

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position; // Store the initial position
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new Y position based on a sine wave
        float newY = Mathf.Sin(Time.time * speed) * amplitude;

        // Apply the new Y position, oscillating around the original startPosition
        transform.position = startPosition + new Vector3(0, newY, 0);

        // Rotate around the Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}