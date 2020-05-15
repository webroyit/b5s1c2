using UnityEngine;

public class Chain : MonoBehaviour
{
    // Access Transform property on unity
    public Transform player;

    // static means that it can be access from anywhere without needing a reference to the instance of the class, but only the type
    public static bool isFired;

    // Start is called before the first frame update
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the user input
        // You change change the input key for "Fire1" on Edit -> Project Setting -> Input Manager
        if(Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }
        if(isFired)
        {

        } else{
            // Move the chain based on the player position
            transform.position = player.position;

            // Set the Y value to 0 to hide the chain when it is not fired
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
