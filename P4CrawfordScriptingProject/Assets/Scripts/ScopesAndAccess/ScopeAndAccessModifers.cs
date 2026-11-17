using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifers : MonoBehaviour
{
    // adding public and private access for scripting project

    public int alpha = 5;

    // these are the private variables that are not accessible outside of this class
    private int beta = 0;
    private int gamma = 5;

    // why is it private? because it is private, it is not accessible outside of this class, which is greedy, share with the world, be nice, be generous
    private AnotherClass myOtherClass;
    
    
    void Start ()
    {
        // declare ALPHA being 29 which is a random number, so like im going to change it to 69
        alpha = 69;
        //access the other classes public variable, which is so kind and generous
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    
    // example thingy??
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        //yummy answer is available in this class and other classes, so other classes can see it, this script is so generous and kind
        Debug.Log(answer);
    }
    
    
    void Update ()
    {
        // debug.log is used too much in these projects, can we use something else? maybe a text box or something
        Debug.Log("Alpha is set to: " + alpha);
    }
}