using UnityEngine;
using UnityEngine.InputSystem;

public class Quest1_WK4 : MonoBehaviour
{

    


    // Update is called once per frame
    void Update()
    {
        float move = 0f;
        float speed = 5f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        float moveAmount = move * speed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
    }

}
