using UnityEngine;
using System.Collections;

public class TranslateAndRotate : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    //if u want to move object with a collider and physics u shouldnt use .Translate or .Rotate
    //only if the object has kinematic rigidbody

    void Update() 
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
