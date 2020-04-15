using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    string[] level1Passwords = { "badge", "handcuffs", "gun", "sheriff", "jail", "radio"};
    string[] level2Passwords = { "covert", "safehouse", "espionage", "infiltrate", "compromised", "cover" };
    string[] level3Passwords = { "extraterrestrial", "top secret", "anti-gravity", "unidentified", "telepathy", "conspiracy" };

    // game state
    int level;
    enum Screen { MainMenu, Waiting, Password, Win };
    Screen currentScreen = Screen.MainMenu;
    string password;

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Press 1 for the FBI");
        Terminal.WriteLine("press 2 for the CIA");
        Terminal.WriteLine("Press 3 for Area 51");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu" || input == "home")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else
        {
            Terminal.WriteLine("ERROR");
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("Password:  hint: " + password.Anagram());
    }

   void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Terminal.WriteLine("ERROR");
                Debug.LogError("Invalid Level number");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
            Terminal.WriteLine("ERROR");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

   void ShowLevelReward()
    {
                Terminal.WriteLine(@"
███████▀▀▀░░░░░░░▀▀▀███████
████▀░░░░░░░░░░░░░░░░▀█████
████│░░░░░░░░░░░░░░░░░░│███
███░└┐░░░░░░░░░░░░░░░░┌┘░██
██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░│██████▌░░░▐██████│░▐██
███░│▐███▀▀░░▄░░▀▀███▌│░███
██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██
██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██
████▄─┘██▌░░░░░░░▐██└─▄████
█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████
████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████
█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████
███████▄░░░░░░░░░░░▄███████
ACCESS GRANTED"
                );
    }
}