using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3: MonoBehaviour
{
    //  Create a function that, given two integers (the first one will be the dividend and the
    //  second one, the divisor), determines if the division is exact.The function must display a
    //message saying if the division of dividend by divisor is exact or not.The function must not
    //return anything

    public int isDivisor = 3;
    public int isDividend = 15;
    private int result;

    private void Start()
    {
        Operation();
    }
    private void Operation()
    {
        result = isDividend % isDivisor;

        if(result == 0)
        {
            Debug.Log("The division is exact");

        }
        else
        {
            Debug.Log("The division is not exact");
        }
    }


}
