using UnityEngine;
using UnityEngine.InputSystem;

public class Worksheet3 : MonoBehaviour
{
    // Question 1
    float movement = 0.05f;
    float moveDirections = 0.04f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

        


    // Update is called once per frame
    void Update()
    {
        
        // Question 1
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(-movement, 0, 0);
            //Question 2
           RotateLeft();
            // Question 3
            Goleft();
            
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(movement, 0, 0);
            // Question 2
            RotateRight();
            // Question 3
            GoRight();

        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            GoUp();
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            GoDown();
        }

        
        void Goleft()
        {
            transform.Translate(-moveDirections, 0f, 0f);
            Debug.Log("Moving Left");
        }
        void GoRight()
        {
            transform.Translate(moveDirections, 0f, 0f);
            Debug.Log("Moving Right");
        }
        void GoUp()
        {
            transform.Translate(0f, moveDirections, 0f);
            Debug.Log("Move Up");
        }
        void GoDown()
        {
            transform.Translate(0f, -moveDirections, 0f);
            Debug.Log("Move Down");
        }

        
    }
    // Question 2
    void RotateLeft()
    {
        transform.Rotate(0f,0f,2f);
    }

    void RotateRight()
    {
        transform.Rotate(0f,0f,-2f);
    }
}
