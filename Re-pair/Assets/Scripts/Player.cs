using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    //Floats
    public float speed = 6f;
    public float jump = 10;
    private  float moveInputX;
    //Bools
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Man får ett värde som multipliseras med "speed" för att bestämma velocity;
        moveInputX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInputX * speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
    
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = false;
    }
}


