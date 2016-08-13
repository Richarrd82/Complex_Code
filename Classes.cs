using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour {

    //Variables = boxes, Functinons = machines, Classes = factory
    //Classes are containers for functions and variables to group things that work together
    //Classes should be dedicated to one task

    public class Stuff {

        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        //The name of the Constructor is always the name of the Class
        //Constructors dont have return type(not even void)
        //Class can have multiple Constructors but only one of them gets called when an Object is initalised
        //Class will choose the one that matches its parameters


        //Constructor that allows us to set custom parameters
        public Stuff(int bul, int gre, int roc) 
        {      
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu) 
        {
            bullets = bul;
            fuel = fu;

        }

        //Constructor that sets default value
        public Stuff() 
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }


    //Creating an Instance (an Object) of the stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);                     

    public Stuff myOtherStuff = new Stuff(50, 1.5f);                
    

    void Start() 
    {
        Debug.Log(myStuff.bullets);
    }
}	
