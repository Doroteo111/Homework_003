using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_6 : MonoBehaviour
{
    
    public float number1 = 10;
    public float number2 = 4;
   
    private void Start()
    {
        isLarger(number1,number2);
    }

    
    private float isLarger(float x, float y)
    {

        if (x > y)
        {
            Debug.Log($"The number {x} is the largest");  //decision operator if-else
            return x;

        }
        else
        {
            Debug.Log($"This number {y} is the largest");
            return y;
        }
    }
}