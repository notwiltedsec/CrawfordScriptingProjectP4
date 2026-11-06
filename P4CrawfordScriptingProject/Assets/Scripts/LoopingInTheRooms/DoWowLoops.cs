using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWowLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //yummy variables except its bool what is a bool?
        bool shouldContinue = false;

        //my do while loop is gonna run while shouldContinue is true
        // if its true then in a cool way print the message and then set shouldContinue to false

        do
        {
            Debug.Log("hi cool world");
        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
