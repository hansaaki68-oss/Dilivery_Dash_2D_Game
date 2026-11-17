using UnityEngine;
using UnityEngine.InputSystem;

// Worksheet 3 Question 5
public class Questt5_Worksheet3 : MonoBehaviour
{
    float step = 0.05f;
    float spin = 2f;

    // Update is called once per frame
    void Update()
    {
        // A key - rotates left
        if (Keyboard.current.aKey.isPressed)
        {
            TurnLeft();
        }

        // D key - rotates right
        if (Keyboard.current.dKey.isPressed)
        {
            TurnRight();
        }

        // W key - drives forward
        if (Keyboard.current.wKey.isPressed)
        {
            DriveForward();
        }

        // S key - drives backward
        if (Keyboard.current.sKey.isPressed)
        {
            DriveBack();
        }

        // Space key - prints Horn (uses wasPressedThisFrame to avoid repeating every frame)
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Horn");
        }
    }

     // Turning Methods
    void TurnLeft()
    {
        Debug.Log("Turning Left");
        // Rotates around the Z axis counter-clockwise
        transform.Rotate(0f, 0f, spin); 
    }

    void TurnRight()
    {
        Debug.Log("Turning Right");
        // Rotates around the Z axis clockwise
        transform.Rotate(0f, 0f, -spin); 
    }

    // Driving Methods
    void DriveForward()
    {
        Debug.Log("Driving Forward");
        // Translates upward along its local Y axis (forward direction for top-down 2D)
        transform.Translate(0f, step, 0f); 
    }

    void DriveBack()
    {
        Debug.Log("Driving Backward");
        // Translates downward along its local Y axis
        transform.Translate(0f, -step, 0f); 
    }
}
