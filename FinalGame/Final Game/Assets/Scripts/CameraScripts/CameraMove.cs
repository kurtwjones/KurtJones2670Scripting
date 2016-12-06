using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public Transform player;
    private Vector3 tempPosition;
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x , 3, -10);
	}
}
