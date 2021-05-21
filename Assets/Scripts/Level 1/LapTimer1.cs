using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// PURPOSE: countdown timer for level 1

public class LapTimer1 : MonoBehaviour
{
    public static int Min_Count = 2;
    public static int Second_Count = 59;
    public static float Milli_Count = 9;
    public static string T_Milli;
    public bool TimerOut = false;


    public GameObject Minute;
    public GameObject Second;
    public GameObject Milli;
    public GameObject FL_Trigger;


    private void Update()
    {
        if (TimerOut == false)
        {
            if (Min_Count >= 0) // if there are minutes, post them on UI.
            {
                if (Min_Count >= 10)
                {
                    Minute.GetComponent<Text>().text = "" + Min_Count + ":";
                }
                else
                {
                    Minute.GetComponent<Text>().text = "0" + Min_Count + ":";
                }
            }
            else // If minute hits -1, set seconds and milliseconds to -1 as well cause there is no more carries for either seconds and then millis. 
            {
                Second_Count = -1;
                Milli_Count = -1;
            }

            if (Second_Count >= 0) // if there are seconds, post them on UI. 
            {
                if (Second_Count >= 10)
                {
                    Second.GetComponent<Text>().text = "" + Second_Count + ".";
                }
                else
                {
                    Second.GetComponent<Text>().text = "0" + Second_Count + ".";
                }

            }

            else // if seconds = -1, then there are no more minutes to carry over.
            {
                if (Min_Count == 0) // exit case for minutes 
                {
                    Min_Count = -1;
                }
                else
                {
                    Second_Count = 59;
                    Min_Count -= 1;
                }
            }

            if (Milli_Count >= 0) // milli is greater than 0, post and subtract 
            {
                Milli_Count -= Time.deltaTime * 10;
                T_Milli = Milli_Count.ToString("F0"); // 
                Milli.GetComponent<Text>().text = "" + T_Milli;
            }

            else // if milli = -1, check if there are seconds to carry over. If there is not, set the milli to stop. Otherwise, keep subtracting from seconds.
            {
                if (Second_Count == -1)
                {
                    Milli_Count = 0;
                }
                else
                {
                    Milli_Count = 9;
                    Second_Count -= 1;
                }
            }

        }
        TimesUp();
    }


    private bool TimesUp()
    {
        if (Min_Count == -1 && Second_Count == -1 && Milli_Count == 0)
        {
            TimerOut = true;
            return TimerOut;
        }
        return false;
    }
}
