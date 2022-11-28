using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    public int number = 4;
    private int result;

    private void Start()
    {
        isEven(number);
    }

    private bool isEven(int x)
    {
        result = x % 2;     //module operation
        if(result == 0)
        {
            Debug.Log("This number  is even");  //decision operator if-else
            return true;

        }
        else
        {
            Debug.Log("This number is not even");
            return false;
        }
    }
}
