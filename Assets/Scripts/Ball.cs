using UnityEngine;

public class Ball : MonoBehaviour
{
    // Allows you to edit Vector2 values on Unity
    public Vector2 startForce;

    // Reference to the next ball prefab
    public GameObject nextBall;

    // Access Rigidbody2D property
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Move the ball to the right
        // ForceMode2D.Impulse only allow the ball to move if the value is small
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Split the ball
    public void Split()
    {
        if(nextBall != null)
        {
            // Spawn a new ball
            // rb.position is the current position of the ball
            // Quaternion.identity to prevent rotation
            // Vector2.right to move the new ball to the right
            GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);

            // Vector2.left to move the new ball to the left
            GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            // first argument is the direction
            // seconed argument push the ball up
            ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
        }

        // Remove the current ball
        Destroy(gameObject);
    }
}
