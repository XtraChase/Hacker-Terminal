using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour

 
{
    // Start is called before the first frame update
    void Start()
    {
       
        ShowMainMenu("Select a hacking objective");
        print("Hello" + "World");
    }

    void ShowMainMenu (string greeting)
    {
        Terminal.ClearScreen(); 
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Press 1 for the police station");
        Terminal.WriteLine("press 2 for the FBI");
        Terminal.WriteLine("Press 3 for Area 51");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        print("The user typed " + input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
