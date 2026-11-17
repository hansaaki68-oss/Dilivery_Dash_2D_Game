using UnityEngine;
using UnityEngine.InputSystem;

// Quest2_Worksheet3

public class Quest2_Worksheet3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            RotateLeft();
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            RotateRight();
        }
    }

    void RotateLeft()
    {
        transform.Rotate(0f, 0f, 2f);
    }

    void RotateRight()
    {
        transform.Rotate(0f, 0f, -2f);
    }
}
