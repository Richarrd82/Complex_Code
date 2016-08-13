using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

    void Start () 
    {
        bool shouldContinue = false;

        do                                        //the code will run then it will check the condition
        {                                         //the body is guranteed to run at least once
            print("Hello World");

        } while (shouldContinue == true);
    }
}
