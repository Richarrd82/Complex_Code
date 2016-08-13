using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

    int numEnemies = 3;

    void Start () 
    {
        for (int i = 0; i < numEnemies; i++)            //keyword (optional(declare and initialise); conditional; optional(increment/decrement))
        {
            Debug.Log("Creating enemy number: " + i);   //in programming counting begins at 0
        }
    }
}
