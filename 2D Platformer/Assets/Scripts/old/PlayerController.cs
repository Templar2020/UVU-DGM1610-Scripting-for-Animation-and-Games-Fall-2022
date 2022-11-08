using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    
    [Header("GroundCheck")]
    private bool isGrounded;    
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private float moveVelocity;

    public AudioClip marker;
    
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
       isGrounded = true;
       rb = GetComponent<Rigidbody2D>();

       source = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        // Ground Check Sensor
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

       // Non-Stick Player 
       moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
           moveVelocity = speed; 
        }
        if(Input.GetKey(KeyCode.A))
        {
           moveVelocity = -speed; 
        }
        // Move player left and right
        rb.velocity = new Vector2(moveVelocity,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }  

    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        source.PlayOneShot(marker, 1.0f);
    }

}
