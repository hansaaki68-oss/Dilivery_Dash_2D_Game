using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    // Using SerializeFilled we can acces the viriable inside the inspector.
    [SerializeField] float moveSpeed;
    [SerializeField] float steerSpeed;
 

    // This input make usnity listen to your key.

    
    // float moveSpeed = 0.03f;
    // float steerSpeed = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        //This rotate the object to 45 angle
        //transform.Rotate(0,0, 45f);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = 0f;

        float steer = 0f;
        
        // Checks is W is pressed
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        
        // Check if S is pressed
        if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        // Check if A is pressed
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        // Check if D is pressed
        if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;
        
        transform.Rotate(0,0, steerAmount );
        transform.Translate(0, moveAmount, 0);
    }


}
