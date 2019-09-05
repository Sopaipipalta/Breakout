using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            rend.material.SetColor("_EmissionColor", Random.ColorHSV());
         //   rend.material.SetColor("_Color", Random.ColorHSV());

        }
    }
}
