﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
   
{
    public float paddleSpeed = 1f;
    private Vector3 playerPos = new Vector3(0, 0, 0);
 

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal")*paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -17f, 17f), 0, 0);
        transform.position = playerPos;
    }
}
