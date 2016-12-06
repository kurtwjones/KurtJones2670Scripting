using UnityEngine;
using System.Collections;

public class Pick_Up : MonoBehaviour {

    public int counter = 0;
    public Transform pick_up;
	// Use this for initialization
	void OnTriggerEnter()
    {
        transform.position = new Vector3(Random.Range(-10,10), 1, 0);
        counter++;
    }
}
