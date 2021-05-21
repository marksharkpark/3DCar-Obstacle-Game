using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    // Start is called before the first frame update
    public static int SceneNum;

    void Start()
    {
        if(SceneNum == 0)
        {
            StartCoroutine(ToSplashTwo ());
        }
        if(SceneNum == 1)
        {
            StartCoroutine(ToMainMenu());
        }
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(5);
        SceneNum = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneNum = 2;
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
