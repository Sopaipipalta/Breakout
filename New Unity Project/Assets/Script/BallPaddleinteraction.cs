using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPaddleinteraction : MonoBehaviour
{
    public float adjacentLenght;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //standar get components to acces the things we're later going to access and then change
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            GameObject ball = collision.gameObject;

            //first of our getting
            float collisionPosition = collision.transform.position.z;
            float centrePoint = transform.position.z;

            //The magnitud is basicalli the speed the object is moving
            //mathmatically speaking it's the lenght of a vector
            float magnitude = rb.velocity.magnitude;

            //working out the opposite length
            float oppositeLength = (collisionPosition - centrePoint);

            //implementing the equation
            float rotation = Mathf.Atan(oppositeLength / adjacentLenght) * Mathf.Rad2Deg;

            //implementing the result + some tweaks to get the ball angle in the right direction because
            //0 degrees in Y is facing up
         ball.transform.rotation = Quaternion.Euler(0, rotation -90, 0);

            //now that ball is facing the right direction again we set the velocity to be 
            //the speed it was going previously but in the new forward facing vector
            rb.velocity = ball.transform.forward * magnitude;
        
    
        }
    }
    
}
