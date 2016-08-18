using UnityEngine;
using System.Collections;

public class SimpleArrays : MonoBehaviour {

    //Arrays are a way of storing a collection of data of the same type together
    //Elements are items in an Array
    //To acces the first Element we use 0 a so on

    int[] myIntArray = new int[5];
    //type[] nameOfArray = new type [number of elements];

    int[] myIntOtherArray = { 12, 76, 8, 937, 903 };
    //type[] nameOfArray = {value, value, value, value, value};

	void Start ()
    {
        myIntArray[0] = 12;
        myIntArray[1] = 76;
        myIntArray[2] = 8;
        myIntArray[3] = 937;
        myIntArray[4] = 903;

        //nameOfArray[index of element to access] = value;
	}
	
    for(int i = 0; i < myIntArray.Length; i++) 
    {
        myIntArray[i] = .....
        //[i] is currently 0 so it is refering to the first elemnt of the Array
    }
}
