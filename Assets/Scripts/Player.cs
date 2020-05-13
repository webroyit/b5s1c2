using UnityEngine;

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
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }
}
