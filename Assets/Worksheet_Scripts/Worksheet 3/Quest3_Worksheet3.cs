using UnityEngine;
using UnityEngine.InputSystem;

public class Quest3_Worksheet3 : MonoBehaviour
{
    
    float movements = 0.04f;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            GoUp();
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            GoDown();
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Goleft();
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            GoRight();
        }
    }


    void GoUp()
    {
        transform.Translate(0f, movements, 0f);
        Debug.Log("Move Up");
    }

    void GoDown()
    {
        transform.Translate(0f, -movements, 0f);
        Debug.Log("Move Down");
    }

    void Goleft()
    {
        transform.Translate(movements, 0f, 0f);
        Debug.Log("Move Left");
    }

    void GoRight()
    {
        transform.Translate(-movements, 0f, 0f);
        Debug.Log("Move Right");
    }
}
