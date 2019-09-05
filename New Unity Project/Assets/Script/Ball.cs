using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float BallInitialSpeed = 700f;
    private Rigidbody rb;
    private bool BallInPlay;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
        
            BallInitialSpeed = 700f;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")&& BallInPlay == false)
        {
            transform.parent = null;
            BallInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(BallInitialSpeed, BallInitialSpeed, 0));
        }
    }
}
