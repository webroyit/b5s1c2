using UnityEngine;

public class Chain : MonoBehaviour
{
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
        
    }
}
