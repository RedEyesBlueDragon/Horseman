using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barier : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(gameObject.GetComponent<Horseman>() != null)
        {
            GameControl.instance.Scored();
        }

    }

}
