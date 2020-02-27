using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closer : MonoBehaviour
{
    public GameObject closex;
    public int score = 0;
    public float spawnRate = 4f;

    public void closethis()
    {
        PlayerPrefs.SetInt("SampleScene", score);
        PlayerPrefs.SetFloat("SampleScene", spawnRate);
        closex.SetActive(false);
    }
}
