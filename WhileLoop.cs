using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

    int cupsInTheSink = 4;

    void Start () 
    {
        while (cupsInTheSink > 0)  //key word (condition) as long as the conditional is true the code in {} will repeat
        {            
            Debug.Log("I've washed a cup");
            cupsInTheSink--;
        }
    }
}
