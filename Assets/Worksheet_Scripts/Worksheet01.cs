using UnityEngine;

public class Worksheet01 : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Welcome_Q01();
      WelcomeWithParameters("Crystal");
      PrintObjectName();
    }

    // Update is called once per frame
    void Update()
    {
      // Welcome_Q02();
      // Printslogs();
    }

    // Write a void method Welcome that prints "Welcome to class" and show how to call it.
    void Welcome_Q01()
    {
      Debug.Log("Welcome to class SWD4.2B");
    }

    // Print a message every frame. The message should be stored in a method and called 
    // from either Start() or Update()
    void Welcome_Q02()
    {
      Debug.Log("Hello, Welcome to today leason");
    }

    // Change Welcome so it takes a string name and prints "Welcome to class " + name.
    // Qustion 3
    void WelcomeWithParameters(string name)
    {
      Debug.Log("Welcome to Class" +name);
    }  

    // Qustion 4
    void Welcome_Q04(string name = "player")
    {
      Debug.Log("Welcome to our group" + name );
    }
   
    // Qustion 5
    void PrintObjectName()
    {
      Debug.Log("Object name: " + gameObject.name);
    }

   
    // Qustion 6
    void Printslogs()
    {
      Debug.Log("This is a normal log");
      Debug.Log("This is a warning log");
      Debug.Log("There is an error in your work");
    }
}


