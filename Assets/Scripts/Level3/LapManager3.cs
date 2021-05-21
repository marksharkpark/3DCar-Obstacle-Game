using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// PURPOSE: Saving the time that is done by LapTimer and displaying to UI, leftover time. 
public class LapManager3 : MonoBehaviour
{
    public GameObject FL_Trigger, HL_Trigger, CoinTrigger;
    public GameObject Min_Count, Second_Count, Milli_Count;

    public void OnTriggerEnter()
    {
        // always updates after a lap, need to set so it updates only after every best lap.
        if (LapTimer3.Second_Count <= 9)
        {
            Second_Count.GetComponent<Text>().text = "0" + LapTimer3.Second_Count + ".";
        }
        else
        {
            Second_Count.GetComponent<Text>().text = "" + LapTimer3.Second_Count + ".";
        }
        if (LapTimer3.Min_Count <= 9)
        {
            Min_Count.GetComponent<Text>().text = "0" + LapTimer3.Min_Count + ".";
        }
        else
        {
            Min_Count.GetComponent<Text>().text = "" + LapTimer3.Min_Count + ".";
        }

        Milli_Count.GetComponent<Text>().text = "" + LapTimer3.T_Milli;


        // Resetting values for next lap 

        LapTimer3.Milli_Count = 0;
        LapTimer3.Second_Count = 0;
        LapTimer3.Min_Count = 0;

        HL_Trigger.SetActive(true);
        FL_Trigger.SetActive(false);
    }
}
