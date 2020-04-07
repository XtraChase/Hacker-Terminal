using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
       
        ShowMainMenu();
    }

    void ShowMainMenu () {
        Terminal.ClearScreen(); 
        Terminal.WriteLine("Press 1 for the Police Station");
        Terminal.WriteLine("press 2 for the FBI");
        Terminal.WriteLine("Press 3 for Area 51");
        Terminal.WriteLine("Enter your selection:");
    }
     // game state
    int level;

    void OnUserInput(string  input) {
        if (input == "menu") {
            ShowMainMenu();
        }
        else if(input == "1") {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else {
            Terminal.WriteLine("Error");
        }
    }

    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Begin Hacking the Police Station");
    }

    // Update is called once per frame
    void Update() {
        
    }
}
