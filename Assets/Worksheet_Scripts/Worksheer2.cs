using UnityEngine;

public class Worksheer2 : MonoBehaviour
{

    // Qustion 1
    float moveSpeed;

    // Question 4
    // use private variables to follow a core programming rule called encapsulation (protecting your data)
    private int maxHealth = 100;
    private int currentHealth;

    // Question 5
    float spin = 2f;
    float move = 0.05f;

    // Qeustion 6
    private int frameCounter = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Question 1
        SetSpeed(0.5f);
        Debug.Log("Current moveSpeed: " + moveSpeed);
        
        // Question 2
        overloading("Hello");
        overloading(13);

        // Question 3
        transform.Rotate(0,0,30);

        // Question 4
        // Initializing current health
        currentHealth = maxHealth;
        // Calls to take damage(30) three time to test
        takeDamage(30);
        takeDamage(30);
        takeDamage(30);


    }

    // Update is called once per frame
    void Update()
    {
        // Question 3
        transform.Rotate(0,0,2f);
        // Question 5
        transform.Rotate(0, 0, spin);
        transform.Translate(0, 0, move);
        // Question 6: This runs continuously every frame
        NudgeAndSpin();

        // Question 7: This spins the object but stops after 300 frames
        SpinFor300Frames();
    }

    // Question 1
    void SetSpeed(float speed)
    {
        moveSpeed = speed;
    }

    // Question 2
    void overloading(string message)
    {
        Debug.Log("Showing String: " + message);
    }

    void overloading(int number)
    {
        Debug.Log("Showing Integer" + number);
    }

    // Question 4
    void takeDamage(int amount)
    {
        // subtract health
        currentHealth -= amount;

        // Ensure the health never goes below 0
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        // Log remaning health
        Debug.Log("Remaining Health: " + currentHealth);

        // Call Die() if health ever goes 0
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Player Died");

        gameObject.SetActive(false);
    }
    
    // Question 6
    void NudgeAndSpin()
    {
        // Translates 0.05 units on the X-axis
        transform.Translate(0.05f, 0, 0);
        
        // Rotates 3 degrees around the Z-axis
        transform.Rotate(0, 0, 3f);
    }

    // Question 7
    void SpinFor300Frames()
    {
        if (frameCounter < 300)
        {
            // Spin the object (e.g., 2 degrees around the Y-axis per frame)
            transform.Rotate(0, 2f, 0);
            
            // Increment the counter by 1 every frame
            frameCounter++;
        }
        
    }
}
