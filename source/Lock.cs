using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    public GameObject locktext;
    public static int highscore = 0;

    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        if (highscore >= 350)
            {
                locktext.SetActive(false);
            }
    }
}
