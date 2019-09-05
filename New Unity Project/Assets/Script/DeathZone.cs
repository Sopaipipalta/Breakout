using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Camerashake camerashake;
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.LoseLife();
        StartCoroutine(camerashake.Shake(.15f, .4f));
    }
 
}
