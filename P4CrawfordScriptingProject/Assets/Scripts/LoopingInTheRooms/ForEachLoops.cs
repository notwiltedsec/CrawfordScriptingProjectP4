using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //yummy variables but why are they made out of strings? strings arent edible bro
        string[] strings = new string[3];

        //assign the values to the strings because they are empty and that is not cool
        strings[0] = "cool";
        strings[1] = "variable";
        strings[2] = "world";

        // i actually have no idea what a foreach loop is but i think it loops through the strings and prints them out in a cool way
        foreach (string item in strings)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
