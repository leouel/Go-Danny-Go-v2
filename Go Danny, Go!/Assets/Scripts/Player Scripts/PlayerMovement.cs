﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D myBody;
    public Transform groundCheckPosition;
    public LayerMask groundLayer;
    private bool isGrounded;
    private bool jumped;
    private float jumpPower=5f;

    //health
    public static float health;



    //first function called when running game, then Start()
    //usually use Awake() and Start() for initialization
    void Awake()
    {
        //in Awake() get references to components
        myBody=GetComponent<Rigidbody2D>();
        //anim=GetComponent<Animator>();
        //danny= GetComponent<GameObject>();
    }//ends Awake()


    void Start()
    {
        
    }//ends Start()

    void Update()
    {
        CheckIfGrounded();
        PlayerJump();

        if(health == 0)
            {
            print("GAME OVER/GO BACK TO MENU");
            }

    }//ends Update()

    void FixedUpdate()
    {
        PlayerSlide();
    }//ends FixedUpdate()


    //function to move Danny
    void PlayerSlide()
    {
        float h = Input.GetAxisRaw("Horizontal");

        //if going forward
        if(h>0)
        {
            myBody.velocity= new Vector2(speed, myBody.velocity.y);
        }

        //if going backward
        else if(h<0)
        {
            myBody.velocity= new Vector2(-speed, myBody.velocity.y);
        }

        else{
            myBody.velocity = new Vector2(0, myBody.velocity.y);
        }

    }//ends PlayerSlide()


    /*
    //called everytime collision between 2 game objects
    void OnCollisionEnter2D(Collision2D target)
    {
       // if(target.gameObject.tag == "Ground")
        //print("collision with snow!");
    }
    */

    void CheckIfGrounded()
        {
        isGrounded=Physics2D.Raycast(groundCheckPosition.position, Vector2.down, 0.1f, groundLayer);

        if(isGrounded)
            {
            if(jumped)
                {
                jumped=false;
                }
            }
        }//ends CheckIfGrounded

    void PlayerJump()
        {
        if(isGrounded)
            {
            if(Input.GetKey(KeyCode.Space))
                {
                jumped=true;

                //game code for jump
                myBody.velocity= new Vector2(myBody.velocity.x, jumpPower);




               
                }
            }
        }//ends PlayerJump()

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("HIT DETECTED!!!");
            health -= 0.2f;
            //Debug.Log("Health = " + health);
        }
    }

}//ends PlayerMovement class
