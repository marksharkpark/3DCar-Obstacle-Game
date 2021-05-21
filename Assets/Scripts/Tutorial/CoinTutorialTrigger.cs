using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinTutorialTrigger : MonoBehaviour
{
    // PURPOSE: Decrementing level 1 coin count and destroying the coin when collected.
    public AudioSource kaching;

    private void Start()
    {
        kaching = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        CoinTutorial.coinScore -= 1;
        kaching.Play();
        Destroy(gameObject);
    }

}
