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
        if(isFired)
        {

        } else{
            // Move the chain based on the player position
            transform.position = player.position;
        }
    }
}
