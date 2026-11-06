using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourLoops : MonoBehaviour
// my dumbass named it fourloops and not forloops.. why am i so stupid bro
{
    // yummy varibles
    int coolVariable = 3;
    // Start is called before the first frame update
    void Start()
    {
        //checking for the cool variable
        // if the cool varible is good enough, then it makes the cool guy
        for (int i = 0; i < coolVariable; i++)
        {
            Debug.Log("making cool guy because the variable said " + coolVariable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
