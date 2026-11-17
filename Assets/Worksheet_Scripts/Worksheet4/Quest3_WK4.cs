using UnityEngine;
using UnityEngine.InputSystem;

public class Quest3_WK4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 80f;
        float steer = 0f;

        float speed = 6f;
        float move = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f; // Negative numbers (-1f) rotate Clockwise (turning right).
        }

        // IF Space is held AT THE SAME TIME as W or D, print "Boost"
        if (Keyboard.current.spaceKey.isPressed && (Keyboard.current.wKey.isPressed || Keyboard.current.dKey.isPressed))
        {
            Debug.Log("Boost");
        }
        
        float moveAmount = move * speed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);

        float steerAmmount = steer * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmmount);


    }
}
