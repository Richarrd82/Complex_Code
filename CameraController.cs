using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController thePlayer; 				//accessing player controller script 

	private Vector3 lastPlayerPosition;				//to find out where our player is 
	private float distanceToMove; 					//we want to move the camera by certain amount as the player moves


	void Start () {

		thePlayer = FindObjectOfType<PlayerController>();	//it will search for the player
		lastPlayerPosition = thePlayer.transform.position;	


	}
	

	void Update () {

		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;  //example his x position is 4.3 but last frame it was 4.2 that means distanceToMove is 0.1
																				 // x because we only care about where he is moving left or right

		lastPlayerPosition = thePlayer.transform.position;	  //every frame it will take the player transform position and it will record it as lastPlayerPosition

		this.transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z); 
		// example (x value) current x position is 5 and distanceToMove is 3, 5 + 3 is 8 so the position of the camera will change to 8 and so on

	}
}
