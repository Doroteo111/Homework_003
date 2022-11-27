using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_10 : MonoBehaviour
{
    //Create a function that every time you call it increases the scale by one unit on all
    //axes.The function does not receive any parameters.The function returns nothing.

    public bool GetBigger;
    public Vector3 localScale = new Vector3(1, 1, 1);
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += Vector3.one;
        }
    }

}
