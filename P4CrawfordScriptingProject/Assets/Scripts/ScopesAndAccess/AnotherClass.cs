using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    // these are public variables that can be accessed from other classes which is fun for other classes, good for those other classes 
    public int apples;
    public int bananas;

    // these are private variables that are not accessible outside of this class, which is greedy, share with the world, be nice, be generous
    private int stapler;
    private int sellotape;

    // this is a public method that can be accessed from other classes which is fun for other classes, good for those other classes
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        // the answer is available in this class and other classes, so other classes can see it, this script is so generous and kind
        Debug.Log("mangos total: " + answer);
    }

    // this is a private method that can only be accessed from within this class which is sad. bad for those other classes, good for this class. so greedy
    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        // the answer is only available in this class, so no other classes can see it, this script is so greedy and hungry
        Debug.Log("how many supplies do we have?: " + answer);
    }
}