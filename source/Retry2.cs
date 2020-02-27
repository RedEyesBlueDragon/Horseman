using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry2 : MonoBehaviour
{
    public float spawnRate = 4f;

    public void RestartGame2()
    {
        PlayerPrefs.SetFloat("spawn", spawnRate);
        PlayerPrefs.SetInt("num", 0);
        Sample.iswat = 0;
        SceneManager.LoadScene("NewMain");
    }

    public void RewardedAd()
    {
        Adman.instance.Display_Reward_Video();
    }
}

