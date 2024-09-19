using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Loops : MonoBehaviour
{

    public List<int> numbers = new List<int>();

    void Start()
    {
        for (int i = 0; i <= 5; i++) { }

        foreach (int number in numbers) { }

        while (numbers.Count > 0) { }

        do
        {

        } while (numbers.Count > 0);
    }
}
