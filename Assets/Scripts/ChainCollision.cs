using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    // It is called when there is collision
    void OnTriggerEnter2D(Collider2D col)
    {
        // Hide the chain
        Chain.IsFired = false;
        
        // You will need to set tag of the ball object in Unity to "Ball"
        // Go to the ball object in Unity, click on tag dropdown menu, click "Add Tag...",
        // then click the plus icon and enter the name of the tag
        if(col.tag == "Ball")
        {
            Debug.Log("Split");
        }
    }
}
