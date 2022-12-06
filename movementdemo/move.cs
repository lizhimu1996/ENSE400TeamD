using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 400f;
    public float jump = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Jump();
    }

    private void Update()
    {
        
    }

    void Movement()
    {
        float horimove;
        horimove = Input.GetAxis("Horizontal");
        float facedirection;
        facedirection = Input.GetAxisRaw("Horizontal");
        if (horimove != 0)
        {
            rb.velocity = new Vector2(horimove * speed * Time.fixedDeltaTime, rb.velocity.y);
        }
        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }



    }

    void Jump()
    {
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump * Time.deltaTime);
        }
    }
}
