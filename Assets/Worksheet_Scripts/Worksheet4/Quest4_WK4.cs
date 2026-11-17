using UnityEngine;
using UnityEngine.InputSystem;

public class Quest4_WK4 : MonoBehaviour
{
    float speed = 5f;
    float rotateSpeed = 70f;

    void Update()
    {
        // Calling both methods from Update as required
        MoveHorizontal();
        TurnObject();
    }

    void MoveHorizontal()
    {
        float move = 0f;

        if (Keyboard.current.dKey.isPressed)
        {
            move = 1f; // Move Right
        }
        if (Keyboard.current.aKey.isPressed)
        {
            move = -1f; // Move Left
        }

        float moveAmount = move * speed * Time.deltaTime;
        // Notice moveAmount is now in the FIRST slot (X-axis) for horizontal movement
        transform.Translate(moveAmount, 0, 0); 
    }

    void TurnObject()
    {
        float steer = 0f;

        if (Keyboard.current.eKey.isPressed)
        {
            steer = -1f; // Clockwise
        }
        if (Keyboard.current.qKey.isPressed)
        {
            steer = 1f;  // Counter-clockwise (anticlockwise)
        }

        float steerAmount = steer * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
    }
}
