using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the movement

    void Update()
    {
        // Get the input from the left and right arrow keys (horizontal axis)
        float moveX = Input.GetAxis("Horizontal"); // Left (-1) or Right (+1)

        // Create a movement vector (only in the X direction)
        Vector3 movement = new Vector3(moveX, 0f, 0f);

        // Apply movement to the GameObject
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter()
    {
        Debug.Log("Boom");

        StartCoroutine(WaitToDestroy());
    }


    public IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(2);

        Destroy(gameObject);
    }
}

