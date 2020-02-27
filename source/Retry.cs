using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    
    public float spawnRate = 4f;

    public void RewardedAd()
    {
        Adman.instance.Display_Reward_Video();
    }


    public void RestartGame()
    {


        Sample.scr = 0;
        GameControl.spawnrate = 4f;
        // PlayerPrefs.SetInt("SampleScene", score);
        //PlayerPrefs.SetFloat("spawn", spawnRate);
        PlayerPrefs.SetInt("num", 0);
        Sample.iswat = 0;
        SceneManager.LoadScene("Main");


    }
}
