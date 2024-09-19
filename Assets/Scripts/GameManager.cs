using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public  GameObject CometePrefab;
    // Time interval in seconds
    public float interval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to print the message every interval
        StartCoroutine(PrintMessageEveryXSeconds());
    }

    // Coroutine to print message at regular intervals
    IEnumerator PrintMessageEveryXSeconds()
    {
        while (true)
        {
            // Print the message to the console
            Debug.Log("This message prints every " + interval + " seconds");

            // Wait for the specified interval
            yield return new WaitForSeconds(interval);
        }
    }


}



