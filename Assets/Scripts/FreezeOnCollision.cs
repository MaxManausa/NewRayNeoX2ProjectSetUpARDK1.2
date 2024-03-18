using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnCollision : MonoBehaviour
{
    private Rigidbody arrowRigidbody;
    private void Start()
    {
        arrowRigidbody = GetComponent<Rigidbody>();
        arrowRigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            Collider collider = collision.collider;
    
            if (collider.CompareTag("Target"))
            {
                transform.SetParent(collider.transform);
                arrowRigidbody.isKinematic = true; 
                arrowRigidbody.constraints = RigidbodyConstraints.FreezeAll;
                Debug.Log("Arrow collided with " + name);
            }
        }
    }
}

