using UnityEngine;
using System.Collections;

public class ComplexArrays : MonoBehaviour {

    //if u make the Array public u will see it in the Inspector
    //then u can set the size of the Array and drag and drop GameObjects on the Elemnents to Initialise it

    public GameObject[] players;
    
	void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
	}
}
