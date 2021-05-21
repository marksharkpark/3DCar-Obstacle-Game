using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonTrigger : MonoBehaviour
{
    // PURPOSE: Displaying next level button at finish line. 

    public GameObject TriggerObject, TriggerObject2, TriggerObject3;
    // Start is called before the first frame update
    void Start()
    {
        TriggerObject.SetActive(true);
        TriggerObject2.SetActive(false);
        TriggerObject3.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCar" && CoinTutorial.coinScore == 0)
        {
            TriggerObject.SetActive(true);
            TriggerObject2.SetActive(true);
            TriggerObject3.SetActive(true);
        }
    }
}