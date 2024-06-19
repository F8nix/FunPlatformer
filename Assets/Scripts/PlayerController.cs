using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    public int speed = 6;
    public int jumpForce = 4;

    private bool grounded;
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
         if (Input.GetKey(KeyCode.Space) && grounded){
            Jump();
         }   
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpForce);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
