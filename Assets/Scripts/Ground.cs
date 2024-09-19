using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float y;

    void Update()
    {
        y += 1 * Time.deltaTime;
    }
}