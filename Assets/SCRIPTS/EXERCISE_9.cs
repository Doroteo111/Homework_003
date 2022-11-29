using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_9 : MonoBehaviour
{
    public float base1 = 5;         //AREA: BASE  X  ALTURA /2
    public float height1 = 4;

    private float areaTrin;

    private void Start()
    {
        numberCheck(base1, height1);

    }

    private void numberCheck(float x, float y)
    {
        areaTrin = (x * y) / 2;
        if (x > 0 && y > 0)
        {
           
            Debug.Log($"The area of the triangle is {areaTrin}.");
            
        } 
        
        else 
        {
            Debug.Log("The area cannot be calculated.");
        }
    }
}
