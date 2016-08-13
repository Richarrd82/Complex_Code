using UnityEngine;
using System.Collections;

public class DataTypes : MonoBehaviour {

    //Data types: Value or Reference

    /* Value 
     * 
     * -contains some value
     * -if a value type is change only that specific variable is affected
     * 
     * -bool
     * -string
     * -double
     * -float
     * -int
     * -char
     * -structs -Vector3
     *          -Quaternion
     *
     * 
     *Reference 
     * 
     * -contains memory address where the value is stored
     * -if a reference type changes all variables that contain that memory address will be affected
     * 
     * Classes -Transform
     *         -GameObject
     *  
     */

    void Start() {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
