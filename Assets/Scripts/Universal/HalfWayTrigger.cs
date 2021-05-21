using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HalfWayTrigger : MonoBehaviour
{
    public GameObject FL_Trigger;
    public GameObject HL_Trigger;

    void OnTriggerEnter()
    {
        FL_Trigger.SetActive(true);
        HL_Trigger.SetActive(false);
    }
}
