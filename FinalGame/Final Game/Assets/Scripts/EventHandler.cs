using UnityEngine;
using System.Collections;
using System;

public class EventHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Delegates.MyEvent += MyEventHandler;
        Delegates.EventToPass += EventToPassHandler;
        Delegates.EventString += EventStringHandler;
        Delegates.EventReturn += EventReturnHandler;
	}

    private string EventReturnHandler(string s)
    {
        return "The Animals I Hate The Most Is: " + s;
    }

    private string EventStringHandler()
    {
        print("Do YOU like Cats?");
        return "I Hate Cats";
    }

    private void EventToPassHandler(string s)
    {
        print(s);
    }

    private void MyEventHandler()
    {
        print("ran event");
    }
}
