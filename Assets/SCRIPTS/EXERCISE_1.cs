using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    // Create a function that given a letter (string variable) determines if it is a vowel or
    //not.The function must return a bool variable

    public string Vowel = "a";

    private void Start()
    {
        Letter();
    }

    private bool Letter()
    {
      if(Vowel== "a" || Vowel == "e" || Vowel == "i" || Vowel == "o" || Vowel == "u")
        {
            Debug.Log($"This letter is a vowel");
            return true;

        }
        else
        {
            Debug.Log($"This letter isn't a vowel");
            return false;
        }
    }



   
}
