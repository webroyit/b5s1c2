using UnityEngine;

public class Ball : MonoBehaviour
{
    // Allows you to edit Vector2 values on Unity
    public Vector2 startForce;

    // Access Rigidbody2D property
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Move the ball to the right
        // ForceMode2D.Impulse only allow the ball to move if the value is small
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }
}
