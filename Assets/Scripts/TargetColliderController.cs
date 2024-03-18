using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 5f;
    [SerializeField] private Collider objectCollider;
    [SerializeField] private Collider[] transformColliders;

    private Transform[] transformPoints;
    private int currentTargetIndex = 0;

    void Start()
    {
        transformPoints = new Transform[transformColliders.Length];
        for (int i = 0; i < transformColliders.Length; i++)
        {
            transformPoints[i] = transformColliders[i].transform;
        }
    }

    void Update()
    {
        if (currentTargetIndex >= transformPoints.Length)
        {
            return;
        }

        Vector3 targetPosition = transformPoints[currentTargetIndex].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (objectCollider.bounds.Intersects(transformColliders[currentTargetIndex].bounds))
        {
            currentTargetIndex = (currentTargetIndex + 1) % transformPoints.Length;
        }

        // Smoothly rotate the object towards the target position
        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}