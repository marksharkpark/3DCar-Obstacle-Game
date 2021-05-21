using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTrigger1 : MonoBehaviour
{
    // PURPOSE: Decrementing level 1 coin count and destroying the coin when collected.

    public void OnTriggerEnter(Collider other)
    {
            Debug.Log("Trigger");
            CoinLevel1.coinScore -= 1;
            Destroy(gameObject);
    }

  
}
