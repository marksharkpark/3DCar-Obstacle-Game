using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// PURPOSE: Displaying next level button at finish line. 

public class ButtonTrigger2 : MonoBehaviour
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
        if (other.gameObject.tag == "PlayerCar" && CoinLevel1.coinScore == 0)
        {
            TriggerObject.SetActive(true);
            TriggerObject2.SetActive(true);
        }
    }
}
