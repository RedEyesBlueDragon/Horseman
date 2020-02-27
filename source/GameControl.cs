using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public GameObject adtext;
    public GameObject text;

    public bool gameOver = false;
    public float scrollSpeed = -3f;
    public static float spawnrate = 4f;

    public GameObject neww;
    public int news;
    public Text scoreText;
    public int score = 0;
    public int iswatched = 0;


    public Text best;
    public int highscore = 0;

    public int ist = 0;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // highscore = PlayerPrefs.GetInt("SampleScene", highscore);
            //    highscore = Sample.highscore1;
            highscore = PlayerPrefs.GetInt("highscore", highscore);
            // score = PlayerPrefs.GetInt("SampleScene", score);
            iswatched = Sample.iswat;
            ist = PlayerPrefs.GetInt("num", ist);

            if (ist == 1)
            {
                score = Sample.scr;
            }


            news = 0;

        }

        else if (instance != this)
        {
            Destroy(gameObject);

        }

    }




    // Start is called before the first frame update
    public void HorsemanDie()
    {
        gameOverText.SetActive(true);

        gameOver = true;
        Sample.counter++;
        if (Sample.counter > 4)
        {
            Sample.counter = 1;
        }


        if (ist == 0)
        {
            adtext.SetActive(true);

        }

        else if (ist == 1)
        {
            iswatched = 0;
            ist = 0;
            PlayerPrefs.SetInt("num", ist);
            Sample.iswat = 0;
            Sample.scr = 0;
        }

        if (Sample.counter == 4)
        {
            Adman.instance.Display_Inter();
        }


        if (score > highscore)
        {
            highscore = score;
            news = 1;
            PlayerPrefs.SetInt("highscore", highscore);
            Sample.highscore1 = highscore;


        }
        // PlayerPrefs.SetInt("SampleScene", score);
        Sample.scr = score;
        best.text = "Best : " + highscore;
        if (news == 1)
        {
            neww.SetActive(true);
        }
    }

    public void Revive()
    {
        iswatched = 1;
        Sample.iswat = 1;
        ist = 1;
        PlayerPrefs.SetInt("num", 1);
        // PlayerPrefs.SetInt("SampleScene", iswatched);
        text.SetActive(true);
        gameOverText.SetActive(false);
        adtext.SetActive(false);
        neww.SetActive(false);

        // PlayerPrefs.SetInt("SampleScene", score);


    }



    public void Scored()
    {


        if (gameOver)
        {

            return;
        }
        score++;
        scoreText.text = "Score: " + score;


    }



    // Update is called once per frame
    void Update()
    {



    }
}
