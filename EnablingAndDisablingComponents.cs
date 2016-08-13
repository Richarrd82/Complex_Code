using UnityEngine;
using System.Collections;

public class EnablingAndDisablingComponents : MonoBehaviour {

    private Light myLight;

    void Start () 
    {
        myLight = GetComponent<Light>();
    }

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            myLight.enabled = !myLight.enabled;         //!myLight.enabled; makes it an on off switch
        }                                               //instead of myLight.enabled = false;
    }                                                   //scripts are also components so we can use .enable on them as well
}
