using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowLoops : MonoBehaviour
{
    //yummy variables
    int cupsInTheSink = 5;
    // Start is called before the first frame update
    void Start()
    {
        //my while loop is gonna run while cupsInTheSink is greater than 0
        while (cupsInTheSink > 0)
        {
            Debug.Log("washed a cup in a cool way");
            cupsInTheSink--;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
