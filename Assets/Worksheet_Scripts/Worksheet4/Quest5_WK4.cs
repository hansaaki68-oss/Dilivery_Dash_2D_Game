using UnityEngine;
using UnityEngine.InputSystem;

public class Quest5_WK4 : MonoBehaviour
{
    float speed = 5f;
    float rotateSpeed = 100f;

    void Update()
    {
        HandleMovement();
        HandleRotation();

        // If left shift is held at any time, print "Shift held"
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            Debug.Log("Shift held");
        }
    }

    void HandleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        string direction = "";

        // Check keys and save direction text
        if (Keyboard.current.wKey.isPressed) { moveY = 1f; direction = "Up"; }
        if (Keyboard.current.sKey.isPressed) { moveY = -1f; direction = "Down"; }
        if (Keyboard.current.dKey.isPressed) { moveX = 1f; direction = "Right"; }
        if (Keyboard.current.aKey.isPressed) { moveX = -1f; direction = "Left"; }

        // Apply movement to both X and Y axes
        transform.Translate(moveX * speed * Time.deltaTime, moveY * speed * Time.deltaTime, 0);

        // If space is held during movement, print "Moving [Direction]"
        if (Keyboard.current.spaceKey.isPressed && direction != "")
        {
            Debug.Log("Moving " + direction);
        }
    }

    void HandleRotation()
    {
        float steer = 0f;
        string rotationDirection = "";

        if (Keyboard.current.eKey.isPressed) { steer = -1f; rotationDirection = "clockwise"; }
        if (Keyboard.current.qKey.isPressed) { steer = 1f; rotationDirection = "anticlockwise"; }

        // Apply rotation
        transform.Rotate(0, 0, steer * rotateSpeed * Time.deltaTime);

        // If space is held during rotation, print "Turning [clockwise/anticlockwise]"
        if (Keyboard.current.spaceKey.isPressed && rotationDirection != "")
        {
            Debug.Log("Turning " + rotationDirection);
        }
    }
}

