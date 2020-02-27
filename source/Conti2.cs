using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conti2 : MonoBehaviour
{
    public static Conti2 instance;

    public void ContGame2()
    {

        PlayerPrefs.SetInt("num", 1);
        Sample.iswat = 1;
        // PlayerPrefs.SetInt("SampleScene", score);
        // PlayerPrefs.SetFloat("SampleScene", spawnRate);
        SceneManager.LoadScene("NewMain");


    }
}
