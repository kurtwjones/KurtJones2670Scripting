﻿using UnityEngine;
using System.Collections;

public class CameraLookAtPlayer : MonoBehaviour {

    public Transform player;
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
	}
}
