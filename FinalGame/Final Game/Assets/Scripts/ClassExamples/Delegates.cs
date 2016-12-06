using UnityEngine;
using System;

public class Delegates : MonoBehaviour {

    public static Action MyEvent;
    public static Action<string> EventToPass;
    public static Func<string> EventString;

   
    public static Func <string, string> EventReturn;

	// Use this for initialization
	void Start () {

        string data = EventReturn("CATS!");
        print (data);
        print(EventString());
        EventToPass("Hello World");

        if(MyEvent != null)
           MyEvent();
	}
	

}
