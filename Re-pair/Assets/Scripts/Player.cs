using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update


    Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
}
