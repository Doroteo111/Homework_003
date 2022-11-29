using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_7 : MonoBehaviour
{

    public float number = 3;
    private float result;

    private void Start()
    {
        RealNumber(number);
    }
    private bool RealNumber(float x)
    {
        result = -x;
        if (x >= 0)
        {
            Debug.Log($"His absolute value is {x}");
            return true;

        }
        else 
        {
            Debug.Log($"His absolute value is {result} ");
            return false;
        }
    }
}