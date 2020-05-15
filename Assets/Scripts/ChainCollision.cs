using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    // It is called when there is collision
    void OnTriggerEnter2D()
    {
        // Hide the chain
        Chain.IsFired = false;
    }
}
