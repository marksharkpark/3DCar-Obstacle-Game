using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PURPOSE: Allowing Car object to be moved by platform, since it is an animation. 

public class AttachCar : MonoBehaviour
{
    public GameObject car;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == car)
        {
            car.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
       if(collision.gameObject == car)
        {
            car.transform.parent = null;
        }
    }
}
