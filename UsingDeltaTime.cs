using UnityEngine;
using System.Collections;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;

    //time between frames is not consistent
    //Time.deltaTime is time between each Update or FixedUpdate function call
    //it can be used to smooth out movement

    void Update()
    {
        countdown -= Time.deltaTime;            
        
        if (countdown <= 0.0f)
            light.enabled = true;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }
}
