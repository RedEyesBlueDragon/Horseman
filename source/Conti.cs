using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conti : MonoBehaviour
{
    public static Conti instance;



    public void ContGame()
    {

        PlayerPrefs.SetInt("num", 1);
        Sample.iswat = 1;
        // PlayerPrefs.SetInt("SampleScene", score);
        // PlayerPrefs.SetFloat("SampleScene", spawnRate);
        SceneManager.LoadScene("Main");


    }
}
