using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PURPOSE: Displaying next level button once player has finished collecting coins.

public class ButtonTrigger3 : MonoBehaviour
{
    public GameObject TriggerObject, TriggerObject2;
    // Start is called before the first frame update
    void Start()
    {
        TriggerObject.SetActive(true);
        TriggerObject2.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCar" && Coin2.coinScore == 0)
        {
            TriggerObject.SetActive(true);
            TriggerObject2.SetActive(true);
        }
    }
}
