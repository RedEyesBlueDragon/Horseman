using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{

    public float spawnRate = 4f;


    public void GoBackMenu()
    {
        Sample.scr = 0;

        PlayerPrefs.SetFloat("spawn", spawnRate);
        SceneManager.LoadScene("SampleScene");
    }
}
