using UnityEngine;
using System.Collections;

public class VariableAssignment : MonoBehaviour {

    public string [] invintory = { "knife", "potion", "letter" } ;
    private int speed = 0;
   
	// Use this for initialization
	void Start () {
        print (invintory);
        print(speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
