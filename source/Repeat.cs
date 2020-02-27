using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
    
    private float groundHorizantalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundHorizantalLength = 32.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizantalLength)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizantalLength * 2f + 2.7f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
