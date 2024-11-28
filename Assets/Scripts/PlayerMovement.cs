using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement
    public float moveSpeed;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;

    private Rigidbody2D rb;
    [HideInInspector]
    public Vector2 moveDir;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveDir.x != 0)
        {
            lastHorizontalVector = moveDir.x;
        }
        if (moveDir.y != 0)
        {
            lastVerticalVector = moveDir.y;
        }
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }

    // Update is called once per frame
    private void Update()
    {
        InputManagement();
    }

    private void FixedUpdate()
    {
        Move();
    }
}