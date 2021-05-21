using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapManager2 : MonoBehaviour
{
    public GameObject FL_Trigger, HL_Trigger, CoinTrigger;
    public GameObject Min_Count, Second_Count, Milli_Count;

    // PURPOSE: Saving the time that is being ran on Level2's laptime during runtime

    public void OnTriggerEnter()
    {
        // always updates after a lap, need to set so it updates only after every best lap.
        if (LapTimer2.Second_Count <= 9)
        {
            Second_Count.GetComponent<Text>().text = "0" + LapTimer2.Second_Count + ".";
        }
        else
        {
            Second_Count.GetComponent<Text>().text = "" + LapTimer2.Second_Count + ".";
        }
        if (LapTimer2.Min_Count <= 9)
        {
            Min_Count.GetComponent<Text>().text = "0" + LapTimer2.Min_Count + ".";
        }
        else
        {
            Min_Count.GetComponent<Text>().text = "" + LapTimer2.Min_Count + ".";
        }

        Milli_Count.GetComponent<Text>().text = "" + LapTimer2.T_Milli;


        // Resetting values for next lap 

        LapTimer2.Milli_Count = 0;
        LapTimer2.Second_Count = 0;
        LapTimer2.Min_Count = 0;

        HL_Trigger.SetActive(true);
        FL_Trigger.SetActive(false);
    }
}
