using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3: MonoBehaviour
{
    public int isDivisor = 3;
    public int isDividend = 15;
    private int result;

    private void Start()
    {
        Operation(isDividend,isDivisor);
    }
    private void Operation(int x, int y)  //module
    {
        result = x % y;

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
