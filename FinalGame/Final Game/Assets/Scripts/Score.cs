using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Score : MonoBehaviour {
    string counter = "0";
    public Text scoreCount;
    
	// Use this for initialization
	void Start () {
        Pick_Up.scoreToPass += scoreHandler;
        counter = "0";
        scoreCount.text = "Score: " + counter;
	}

    private void scoreHandler(string score)
    {
       counter = score;
       scoreCount.text = "Score: " + counter;
    }
}
