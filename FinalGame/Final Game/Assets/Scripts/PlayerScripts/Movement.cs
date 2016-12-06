using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    //initializing variables
    public float speed = 1;
    public float gravity = -9.8f;
    public float jumpSpeed = 500;

    private CharacterController cc;
    private Vector3 tempPosition;
	
	void Start () {
        //character controller
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempPosition.y = gravity;
        tempPosition.x = speed * Input.GetAxis("Horizontal");
        tempPosition *= Time.deltaTime;
        cc.Move(tempPosition);
        if (Input.GetKeyDown("space") && cc.isGrounded)
            transform.Translate(Vector3.up *jumpSpeed* Time.deltaTime);
	}
}
