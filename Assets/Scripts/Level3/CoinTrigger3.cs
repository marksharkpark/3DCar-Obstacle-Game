using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: Decrementing level 3's coin count and destorying the coin when collected.

public class CoinTrigger3 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Coin3.coinScore -= 1;
        Destroy(gameObject);
    }
}
