using UnityEngine;
using System;
using System.Collections;

public class Pick_Up : MonoBehaviour {

    public int counter = 0;
    private const int MAX = 10;
    public static Action<string> scoreToPass;

	void OnTriggerEnter()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-MAX,MAX), 1, 0);
        counter++;
        PassScore();
       
    }
    private void PassScore()
    {
        scoreToPass(counter.ToString());
    }
}
