using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour

 
{
    // Start is called before the first frame update
    void Start()
    {
       
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        Terminal.ClearScreen(); 
        string greeting = "Select a hacking objective";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Press 1 for the police station");
        Terminal.WriteLine("press 2 for the FBI");
        Terminal.WriteLine("Press 3 for Area 51");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
