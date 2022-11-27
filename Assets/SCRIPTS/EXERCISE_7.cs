using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_7 : MonoBehaviour
{
    // Create a function that, given a real number, returns its absolute value. 

    public float number = 3;
    private float result;

    private void Start()
    {
        RealNumber();
    }
    private bool RealNumber()
    {
        result = -number;
        if (number >= 0)
        {
            Debug.Log($"His absolute value is {number}");
            return true;

        }
        else 
        {
            Debug.Log($"His absolute value is {result} ");
            return false;
        }
    }
}