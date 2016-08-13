using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    //Destroy (GameObject / Component, optional delay)

    //public GameObject other;

    void Update() 
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
          //Destroy(gameObject);       
          //Destroy(GetComponent<MeshRenderer>());
          //Destroy(gameObject, 5f); 1f = 1 second
        }

        /* if(Input.GetKey(KeyCode.Space)) 
            {
                Destroy(other);
            }
        */
    }
}
