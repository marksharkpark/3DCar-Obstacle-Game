using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapManager1 : MonoBehaviour
{
    public GameObject FL_Trigger, HL_Trigger, CoinTrigger;
    public GameObject Min_Count, Second_Count, Milli_Count;


    // Function saves the time that is done by LapTimer 

    public void OnTriggerEnter()
    {
        // always updates after a lap, need to set so it updates only after every best lap.
        if (LapTimer1.Second_Count <= 9)
        {
            Second_Count.GetComponent<Text>().text = "0" + LapTimer1.Second_Count + ".";
        }
        else
        {
            Second_Count.GetComponent<Text>().text = "" + LapTimer1.Second_Count + ".";
        }
        if (LapTimer1.Min_Count <= 9)
        {
            Min_Count.GetComponent<Text>().text = "0" + LapTimer1.Min_Count + ".";
        }
        else
        {
            Min_Count.GetComponent<Text>().text = "" + LapTimer1.Min_Count + ".";
        }

        Milli_Count.GetComponent<Text>().text = "" + LapTimer1.T_Milli;


        // Resetting values for next lap 

        LapTimer1.Milli_Count = 0;
        LapTimer1.Second_Count = 0;
        LapTimer1.Min_Count = 0;

        HL_Trigger.SetActive(true);
        FL_Trigger.SetActive(false);
    }
}
