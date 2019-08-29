using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Ball;
    public GameObject CoinParticle;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(CoinParticle, transform.position, Quaternion.identity);
        Instantiate(Ball, transform.position, Quaternion.identity);
        Destroy(gameObject);
       
    }
   
  

}
