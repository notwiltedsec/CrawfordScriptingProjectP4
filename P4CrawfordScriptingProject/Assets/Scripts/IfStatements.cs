using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // these are obvious, but its variable declarations, and they are floats... unless your name is kailyn then it probably wasnt obvious to you.
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update im 99% sure this is what it does but ive never used unity before so i dont know what im doing
    void Start()
    {
        
    }

    // Update is called once per frame or something like that ive never used unity before so i dont know what im doing
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))

 
            TemperatureTest();

            // wow thanks copilot for finishing my code for me, i was just about to write this line of code but you did it for me so thanks 
            coffeeTemperature -= Time.deltaTime * 5f;
        

    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            Debug.Log("do u wanna burn ur tongue off??? dont drink..");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("do u wanna be uncomfortable?? dont drink..");
        }
        else
        {
            Debug.Log("coffee is yummers rn.. drink it.");
        }
    }
}

// this is a comment that is not attached to any code, but it is here to tell you that i am not sure if this is the correct way to do comments in c# because im not smart enough to use c# and i dont know if this is the correct way to do comments in c# but i think it is so im just gonna leave it here and hope that it is correct and that it doesnt
// ^ this comment is stupid 0/10 i hate this 
// ^ this comment is also stupid 0/10 i hate this
// ^ this comment is even worse 0/10 i hate this