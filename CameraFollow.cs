﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerSlime;
    public float cameraDistance = 30.0f;

    void Awake()
    {
        if (!PlayerSlime)
        {
            PlayerSlime = GameObject.FindGameObjectWithTag("Player").transform;
        }
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!PlayerSlime)
        {
            PlayerSlime = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (transform == null)
            return;
        if (PlayerSlime == null)
            return;



        transform.position = new Vector3(PlayerSlime.position.x, PlayerSlime.position.y, transform.position.z);



    }
    
}
