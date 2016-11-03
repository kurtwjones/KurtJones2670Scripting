using UnityEngine;
using System.Collections;
using System;

public class Delgates : MonoBehaviour {

    Action <Delgates> Move;
    Action Idle;
    Action Jump;

    int speed = 200;
   
    void MoveHandler(Delgates _obj)
    {
        print("Moving at " +_obj.speed + "MPH");
        Move = null;
        Idle = IdleHandler;
    }
    void IdleHandler()
    {
        print("Idling");
        Idle = null;
        Jump = JumpHandler;
    }
    void JumpHandler()
    {
        print("Jump");
        Jump = null;
    }

	// Use this for initialization
	void Start () {
        Move = MoveHandler;
       
	}
	
	// Update is called once per frame
	void Update () {
        if(Move != null)
            Move(this);
        if (Idle != null)
            Idle();
        if (Jump != null)
            Jump();
	}
}
