using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Go2 : MonoBehaviour
{
    public static int highscore;

    public void Goo2()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);

        if (highscore >= 350)
        {
            SceneManager.LoadScene("NewMain");
        }
    }

}
