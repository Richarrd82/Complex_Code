using UnityEngine;
using System.Collections;

public class ScriptsAsBehaviourComponents : MonoBehaviour {

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            gameObject.renderer.material.color = Color.red;   //gameObject is refering to the object this script is attached to
                                                              // we are refering to renderer (mesh renderer) then to material, then to color and setting it to red
                                                              // red is a part of the Color class
        }
    }
}
