using UnityEngine;
using System.Collections;

public class AwakeStartUpdateFixedUpdate : MonoBehaviour {

	//Awake and Start are called automatically when the script is loaded
	//Awake is called first, even if the script component isn't enabled
	//Start and Awake will only ever be called Once in the lifetime of a script on a GameObject
	
	void Awake() 
	{
		//References between scripts, initialisation
		//Set Ammo for the enemy
	}
	
	void Start() 
	{
		//Once script component is enabled
		//Allow enemy to Shoot
	}
	
	void Update () 
	{
		/* Called every frame
		* Used for regular updates such as:
		*      -moving non-physics objects
		*      -simple timers
		*      -receiving input
		* Update interval times vary
		*/
	}
	
	void FixedUpdate() 
	{
		/*Called every Physics step
		* Fixed Update intervals are consistent
		* Used for regular updates such as:
		*     -Adjusting physics (Rigidbody) objects
		*/
	}
}
