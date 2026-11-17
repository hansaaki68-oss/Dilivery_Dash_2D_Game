using UnityEngine;
using UnityEngine.InputSystem;

// Question 1 Worksheet 3
public class Qust1_Worksheet3 : MonoBehaviour
{
    float movement = 0.05f;
    float run = 0.08f; // Question 4
    
    // Update is called once per frame
    void Update()
    {
        // Queestipn 4
        float currentSpeed = movement;
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            currentSpeed = run;
        }



        // Question 1
        if (Keyboard.current.leftArrowKey.isPressed)
        {

            // Question 4
            if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(-run, 0f, 0f);

                // Question 1
                //transform.Translate(-currentSpeed, 0f, 0f);
            }

                
            if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(-movement, 0f, 0f);
            }


        }

        

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            if (Keyboard.current.leftShiftKey.isPressed)
            {
                // Question 4
                transform.Translate(run, 0f, 0f);

                // Question 1
                // transform.Translate(currentSpeed, 0f, 0f);
            }

            if (Keyboard.current.leftShiftKey.isPressed == false)
            {
                transform.Translate(movement, 0f, 0f);
            }
            
        }
    }
}
