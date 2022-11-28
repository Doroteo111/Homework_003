using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
     

    public int multi = 5;    //Arithmetic operation + funtion

    private void Start()
    {
        multiplicationTable(multi); 
    }

    private void multiplicationTable(int x) {
        Debug.Log($"{x} x 1 = {x * 1}");
        Debug.Log($"{x}x 2 = {x * 2}");
        Debug.Log($"{x} x 3 = {x * 3}");
        Debug.Log($"{x}x 4 = {x * 4}");
        Debug.Log($"{x} x 5 = {x * 5}");
        Debug.Log($"{x} x 6 = {x * 6}");
        Debug.Log($"{x} x 7 = {x * 7}");
        Debug.Log($"{x}x 8 = {x * 8}");
        Debug.Log($"{x} x 9 = {x * 9}");
        Debug.Log($"{x} x 10 = {x * 10}");
    }
}

