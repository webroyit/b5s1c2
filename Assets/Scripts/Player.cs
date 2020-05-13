﻿using UnityEngine;

public class Player : MonoBehaviour
{
    // Player speed
    public float speed = 4f;

    // Access Rigidbody2D property
    public Rigidbody2D rb;

    private float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        // Represents the direction that the player move
        // It between -1 to 1
        // You can use "a" or left arrow key to move left and "d" or right arrow key to move right
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    // Calculates the movement
    void FixedUpdate()
    {
        // rb.position is the current position of the player
        // Time.fixedDeltaTime to improve performance
        rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
    }    
}
