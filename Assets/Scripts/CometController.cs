using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometController : MonoBehaviour
{
    public float speed = 5f;  // Speed of movement
    public Vector3 direction = Vector3.forward;  // Direction to move (in this case, forward)

    void Update()
    {
        // Move the object in the specified direction
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
