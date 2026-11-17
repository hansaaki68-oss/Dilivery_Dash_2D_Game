using UnityEngine;
using UnityEngine.InputSystem;

public class Quest2_WK4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float steerSpeed = 90f;
        float steer = 0f;

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }

        if (Keyboard.current.spaceKey.isPressed)
        {
            Debug.Log("Turning");
        }

        float steerAmmount = steer * steerSpeed * Time.deltaTime;

        transform.Rotate(0, 0, steerAmmount);
    }

}
