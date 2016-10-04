using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {
    public Transform characterArt;
	// Use this for initialization
	void Start () {
	
	}
    public bool forward = true;
    void FlipCharacter (bool _b)
    {
        characterArt.Rotate(0, 180, 0);
        forward = _b;
    }
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow) && forward)
        {
            FlipCharacter(false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && !forward)
        {
            FlipCharacter(true);
        }
    }
}
