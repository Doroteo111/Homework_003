using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_10 : MonoBehaviour
{
    

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
