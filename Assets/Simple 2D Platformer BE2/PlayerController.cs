using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    Vector2 move;
    float moveX;
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;

    void Start()
    {
        speed = 500f;
        jumpSpeed = 15f;
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveX * speed * Time.fixedDeltaTime, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(0, jumpSpeed);
        }
    }

    private void FixedUpdate()
    {
        //rb2d.velocity = new Vector2(moveX * speed * Time.fixedDeltaTime, rb2d.velocity.y);
    }
}
