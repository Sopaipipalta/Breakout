using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcopy : MonoBehaviour
{
    public float BallInitialSpeed = 600f;
    private Rigidbody rb;
    private bool BallInPlay;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && BallInPlay == false)
        {
            
            BallInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(BallInitialSpeed, BallInitialSpeed, 0));
            new Vector3(transform.position.x, transform.position.y, 0);
        }
       
    }
 
}
