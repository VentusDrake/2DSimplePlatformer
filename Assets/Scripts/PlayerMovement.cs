using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rigidbody2d;
    private float horizontal;
    public float speed;
    public float jumpPower;
    private bool isFacingRight = true;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        speed = 250 * Time.deltaTime;
        jumpPower = 25000 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        horizontal = Input.GetAxisRaw("Horizontal");

        Flip();

        rigidbody2d.velocity = new Vector2(horizontal * speed, rigidbody2d.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbody2d.AddForce(new Vector2(rigidbody2d.velocity.x, jumpPower));
        }
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
