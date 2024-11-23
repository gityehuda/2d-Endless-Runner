using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb2d;
    private Vector2 direction;
    private bool isGrounded = false;
    private bool isJumping = false;

    private Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f));

        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb2d.velocity.y) < 0.001f)
        {
            if(isGrounded == true) 
            {
                 rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                 isGrounded = false;
                 playJump();
            }
           
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
                playRun();
            }
        }
    }

    private void playRun()
    {
        animator.SetTrigger("goRun");
    }

    private void playJump()
    {
        animator.SetTrigger("goJump");
    }

    

}
