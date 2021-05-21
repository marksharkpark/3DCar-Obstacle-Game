using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: Decrementing level 2's coin count and destorying the coin when collected.

public class CoinTrigger2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Coin2.coinScore -= 1;
        Destroy(gameObject);
    }
}
