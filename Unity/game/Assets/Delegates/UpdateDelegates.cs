using UnityEngine;
using System.Collections;
using System;

public class UpdateDelegates : MonoBehaviour {
    int health = 250;
    //actions are a type of delegate. Delegates contain functions just as vars contain data
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndGame;
    
   
	// Use this for initialization
	void Start () {
        //assign the function DisplayHealthHandler to the action displayhealth
        DisplayHealth = DisplayHealthHandler;
	}
    void KillThePlayerHandler()
    {
        health--;
        print(health);
        if (health < 0)
        {
            KillThePlayer = null;
            EndGame = EndGameHandler;
        }
           
           
    }
    void EndGameHandler()
    {
        print("you died. you didnt even try.");
        EndGame = null;
    }
	void DisplayHealthHandler()
    {

        print("health is good.");
        //unassign all functions from displayhealth
        DisplayHealth = null;
        KillThePlayer = KillThePlayerHandler;
    }
	// Update is called once per frame
	void Update () {
        //check if any function is assigned to displayHealth
        //if nothing assigned. Display health will not run
        if (DisplayHealth != null)
        DisplayHealth();

        if (KillThePlayer != null) 
        KillThePlayer();

        if (EndGame != null)
            EndGame();
       
	}
}
