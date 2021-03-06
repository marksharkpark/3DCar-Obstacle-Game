using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITrigger : MonoBehaviour
{
    public GameObject TriggerObject;

    // Start is called before the first frame update
    void Start()
    {
        TriggerObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCar")
        {
            TriggerObject.SetActive(true); 
            StartCoroutine("WaitForSec"); // calling IEnumerator 
        }
    }

    IEnumerator WaitForSec() // IEnumerator lets us use real time seconds
    {
        yield return new WaitForSeconds(5);
        Destroy(TriggerObject); // destroying text 
        Destroy(gameObject); // ensuring collider disappears after once 
    }

  
}
