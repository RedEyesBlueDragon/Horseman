using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goAbout : MonoBehaviour
{
    public void GoAbout()
    {
        SceneManager.LoadScene("About");
    }
}
