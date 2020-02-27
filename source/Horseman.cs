using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horseman : MonoBehaviour
{

    public float upForce = 200f;
    public float jumpForce;

    private bool isDead = false;
    private bool isJumping = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    public float fireRate = 0.5f;
    private float nextFire = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("Notdead",true);
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead == false)
        {
            
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameControl.instance.Scored();
            }

            if (Input.GetMouseButtonDown(0) && isJumping == false)
            {
                rb2d.velocity = new Vector2(0, jumpForce);
                isJumping = true;
                anim.SetTrigger("Run");
            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            isDead = true;
            anim.SetBool("Notdead",false);
            anim.SetTrigger("Die");
            
            GameControl.instance.HorsemanDie();
        }
        else
        {
            isJumping = false;
        }
    }


}
