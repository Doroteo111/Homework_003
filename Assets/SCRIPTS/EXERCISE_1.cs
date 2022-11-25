using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    public string Vowel = "a";

    private void Start()
    {
        Letter();
    }

    private bool Letter()         //decision operator if-else
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
