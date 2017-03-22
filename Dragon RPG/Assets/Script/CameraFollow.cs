﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
	void LateUpdate () {

        if (player == null)
            return;

        this.transform.position = player.transform.position;
    }
}
