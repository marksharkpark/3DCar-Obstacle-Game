using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin2 : MonoBehaviour
{
    //PURPOSE: Setting coin scores for level 2 and updating the count to UI. 

    Text text;
    public static int coinScore;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        coinScore = 6;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinScore.ToString();
    }
}
