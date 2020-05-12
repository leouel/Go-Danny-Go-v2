using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCTRL : MonoBehaviour
{
    public float moveSpeed = 15f;
    public Rigidbody2D rb; //the motor to our object
    Vector2 movement; //horizontal&vertical
    public GameObject gameObj;

    //health
    public static float health;
    
    private void Start()
    {
        health = 1;
        rb = GetComponent<Rigidbody2D>();
    }
    //collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (collision.CompareTag("Wall"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            Debug.Log("HIT DETECTED!!!");
            health -= 0.2f;
            //Debug.Log("Health = " + health);
        }
    }

    void Update()
    {
        //controller
        movement.x = Input.GetAxisRaw("Horizontal"); //left&right pos, keys holding down
        movement.y = Input.GetAxisRaw("Vertical"); //up&down

        if (health <= 0.1)
        {
            //Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
            
    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
