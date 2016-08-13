using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

    //function used to create clones of GameObjects
    //commonly used in context of cloning a prefab
    //at standard Instantiate returns a type called Object

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

	void Update ()
    {
	    if(Input.GetButtonDown("Fire1"))
        {
            //Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);                                //Instantiate will return Object

            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;    //Instantiate will return Rigidbody

            //Type reference;
            //reference = Instantiate(Prefab to clone, Position, Rotation to use) as Type;
             

            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
	}
}
