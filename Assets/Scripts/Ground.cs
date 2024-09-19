using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float startValue = 0f;
    public float endValue = 10000f;
   

    private float currentValue = 0f;

    void Start()
    {
        StartCoroutine(IncreaseValueOverTime());
    }

    IEnumerator IncreaseValueOverTime()
    {
        float elapsedTime = 0f;

        while (currentValue<= endValue)
        {
            // Smoothly interpolate the value based on elapsed time
            currentValue = Mathf.Lerp(startValue, endValue, elapsedTime );
            elapsedTime += Time.deltaTime;

            Debug.Log("Current Value: " + currentValue);

            yield return null; // Wait until the next frame
        }

        currentValue = endValue; // Make sure the value reaches exactly the end value at the end
        Debug.Log("Final Value: " + currentValue);
    }
}