using UnityEngine;
using System.Collections;
using System;
public class sendToRecycler : MonoBehaviour {
    public static Action<sendToRecycler> sendThis;
	// Use this for initialization
	void Start () {
        sendThis(this);
	}

}
