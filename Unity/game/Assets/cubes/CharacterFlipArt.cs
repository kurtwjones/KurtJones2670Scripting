using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {
    public Transform characterArt;
	// Use this for initialization
	
    public bool forward = true;
    void FlipCharacter (KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.UpArrow:
                if (forward)
                {
                 characterArt.Rotate(0, 180, 0);
                    forward = false;
                }

                break;
            case KeyCode.DownArrow:
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                }
                break;
        }
      //  forward = _b;
    }

	void Start()
    {
        
    }
}
