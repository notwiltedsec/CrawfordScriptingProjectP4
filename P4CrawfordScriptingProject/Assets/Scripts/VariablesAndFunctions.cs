using System.Collections;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // wow i think this might be a variable if this wasn't obvious your name better be kailyn bro :sob:
    int myInt = 69;


    // start ISNT called before the first frame update because im evil. (it is called before the frame upd)
    void Start()
    {
        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // update every frame, prepare for lag, but it works 10/10 hack 
    void Update()
    {
        
    }
    // this might be a function. you'll never know,, (it is a function)
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
        
        // 0/10 hack i hate this pls delete
    }
}