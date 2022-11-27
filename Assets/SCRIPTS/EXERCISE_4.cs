using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    // Everytime you click the right side of the mouse, the cube will moves backward

    public Vector3 backCube = new Vector3(0, 0, 2);
    private void Update()            
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position += backCube;
        }
        

    }

}
