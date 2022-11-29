using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_8 : MonoBehaviour
{
   public int year = 2004;
    private int result;

    private void Start()
    {
        leapYear(year);
    }

    private bool leapYear(int x)
    {
        result = x % 4;     //module

        if (result == 0)
        {
            Debug.Log($"The {x}, it's a a lap year");
            return true;

        }
        else
        {
            Debug.Log($"The {x}, it's not a a lap year");
            return false;
        }
    }
}
