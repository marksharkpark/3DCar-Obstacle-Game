using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reload3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        LapTimer3.Min_Count = 1;
        LapTimer3.Second_Count = 59;
        LapTimer3.Milli_Count = 9;
        SceneManager.LoadScene(6);
    }

    
}
