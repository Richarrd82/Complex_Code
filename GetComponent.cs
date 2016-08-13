using UnityEngine;
using System.Collections;

public class GetComponent : MonoBehaviour {

    //Script is considered custom component
    //accessing other scripts and components with GetComponent<>();
    //GetComponent is expensive in terms of procesive power
    //Should be used in Awake() or Start()

    public GameObject otherGameObject;                  //this variable stores a GameObject

    private AnotherScript anotherScript;                //these store references to the other scripts
    private YetAnotherScript yetAnotherScript;          //these are just variables but their type is name of the script
    private BoxCollider boxCol;

    void Awake() 
    {
        //here we initialise our variables 

        anotherScript = GetComponent<AnotherScript>();                          // GetComponent<Type>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();    // GameObjectReference.GetComponent<Type>();
        boxCol = otherGameObject.GetComponents<BoxCollider>();
    }

    void Start () 
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player score is " + yetAnotherScript.playerScore);
        Debug.Log("The player has died " + anotherScript.numOfPlayerDeaths);
    }
}
