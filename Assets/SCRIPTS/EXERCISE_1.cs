using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    public string Vowel = "a";

    private void Start()
    {
        Letter(Vowel);
    }

    private bool Letter(string w)         //decision operator if-else
    {
      if(w == "a" || w == "e" || w == "i" || w == "o" || w == "u")
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
