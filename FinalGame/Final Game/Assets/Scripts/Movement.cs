using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed = 1;
    private CharacterController cc;
    public float gravity = -9.8f;

    private Vector3 tempPosition;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempPosition.y = gravity;
        tempPosition.x = speed * Input.GetAxis("Horizontal");
        tempPosition *= Time.deltaTime;
        cc.Move(tempPosition);
	}
}
