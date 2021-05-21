using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload2 : MonoBehaviour
{
    public void Restart()
    {
        LapTimer2.Min_Count = 1;
        LapTimer2.Second_Count = 30;
        LapTimer2.Milli_Count = 9;
        SceneManager.LoadScene(5);
    }
}
