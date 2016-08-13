using UnityEngine;
using System.Collections;

public class VariablesandFunctions : MonoBehaviour {

    //variables are boxes that contain information
    //different type of box for each type of information
    //variables start with int[type] myInt[name] = 5[value]; 
    //first part is declaration and second is initialisation

    int myInt = 5;

    void Start()                        //Start gets called when the object that this script is attached to enters the scene
    {              
        myInt = MultiplyByTwo(myInt);   //FunctionName (data to send to parameters)
        Debug.Log(myInt);
    }

    //functions take the boxes and give us boxes back or return
    //void doesnt return anything
    //when we start a function we give it a specific box to return
    //int[type] MultiplyByTwo[FunctionName](int number)[type name] - the kind of information we want to feed this machine

    int MultiplyByTwo(int number) 
    {
        int ret;
        ret = number * 2;

        return ret;
    }
}
