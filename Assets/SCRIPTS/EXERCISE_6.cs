using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_6 : MonoBehaviour
{
    // Create a function that, given two real numbers, returns the number that is larger

    public int number1 = 10;
    public int number2 = 4;
   
    private void Start()
    {
        isLarger();
    }

    
    private bool isLarger()
    {

        if (number1> number2)
        {
            Debug.Log($"The number  is the largest");  //decision operator if-else
            return true;

        }
        else
        {
            Debug.Log($"This number is the lowest");
            return false;
        }
    }
}