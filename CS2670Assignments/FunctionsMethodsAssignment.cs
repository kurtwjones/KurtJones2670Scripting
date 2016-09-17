using UnityEngine;
using System.Collections;

public class FunctionsMethodsAssignment : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
       
        {
            Debug.Log("to find out my name press the spacebar!");     
        }

	              }
    void Information ()
    {
        Debug.Log("my name is steve");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space"))
        {
            Information();
        }

    }
}
    /* 
     Variables are containers that hold data.
     we need to give it a type and a name. Then
     we can call it later. Functions are containers
     that run a spicific command then return information.
     You can pass information into your function by placing
     information in the brackets. Functions are great because
     you can create a set of code that can be used many times
     and can be useful for performing certain actions. 
     
     
     */
