using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    #region GameConfigAndState
    //Game config
    string[] level1Passwords = {"books", "checkout", "librarian"};
    string[] level2Passwords = {"prisoner", "handcuffs", "officer","donut","arrest"};
    string[] level3Passwords = {"spacewalk", "darkmatter", "gravity","propulsion","spacewalk"};
    // Game State
    int level;
    string password;
    //Screen enumeration
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    #endregion
    #region Start

    void Start()
    {
        ShowMainMenu();
    }
    #endregion
    #region ShowMainMenu
        void ShowMainMenu()
        {
            currentScreen = Screen.MainMenu;
            Terminal.ClearScreen();
            Terminal.WriteLine("Hello. My name is Joshua.");
            Terminal.WriteLine("Want to play a game?");
            Terminal.WriteLine("Press 1 for your local Library");
            Terminal.WriteLine("Press 2 for the local police station");
            Terminal.WriteLine("Press 3 for the NASA ISS");
            Terminal.WriteLine("Enter your selection:");   
        }
    #endregion
    #region UserInput
    //handle input
        void OnUserInput(string input)
        {
            if( input == "menu") // go back to main menu
            {
                ShowMainMenu();
            }
            else if( currentScreen == Screen.MainMenu )
            {
                RunMainMenu(input);
            }
            else if( currentScreen == Screen.Password )
            {
                CheckPassword(input);
            }
        }
    #endregion
    #region RunMainMenu
        void RunMainMenu(string input)
        {
            bool isValidInput = (input == "1" || input == "2" || input == "3");
            if (isValidInput)
            {
                level = int.Parse(input);
                StartGame();
            }
            else if( input == "007" )
            {
                Terminal.WriteLine("Welcome back Mr. Bond.");   
            }
            else
            {
                Terminal.WriteLine("Please enter valid selection.");
            }
        }
          
    #endregion
    #region StartGame
        void StartGame()
        {
            currentScreen = Screen.Password;
            Terminal.ClearScreen();
            switch(level)
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
                    Debug.LogError("Invalid number");
                    break;
                

            }
            Terminal.WriteLine("Password:");
        } 
    #endregion
    #region CheckPassword
        void CheckPassword(string input)
        {
            if ( input == password )
            {
                DisplayWinScreen();
            }
            else
            {
                Terminal.WriteLine("Wrong Password");
            }
        }
    #endregion
    #region DisplayWinScreen
        void DisplayWinScreen()
        {
            currentScreen = Screen.Win;
            Terminal.ClearScreen();
            ShowLevelReward();
        }
    #endregion
    #region ShowLevelReward
        void ShowLevelReward()
        {
            switch (level)
            {
                case 1:
                    Terminal.WriteLine(@"
    
    ________   ________
.-/|        \ /        |\-.
||||         |         ||||
||||         |         ||||
||||         |         ||||
||||         |         ||||
||/=========\|/=========\||
`----------~___~---------''
        ACCESS GRANTED
        Reward: BOOK
                    ");
                    break;
                case 2:
                    Terminal.WriteLine(@"
    
  ,   /\   ,
  / '-'  '-' \
  |  POLICE  |
  |   .--.   |
  |  ( 01 )  |
  \   '--'   /
   '--.  .--'
       \/
        ACCESS GRANTED
        Reward: BADGE
                    ");
                    break;
                case 3:
                    Terminal.WriteLine(@"

              +   /\
 +              .'  '.   *
        *      /======\      +

    +         |:. (_)  |          *
              ;:.      ;
            .' \:.    / `.
           / .-'':._.'`-. \
           |/    /||\    \|
        ACCESS GRANTED
        Reward: SPACESHIP
                    ");
                    break;
            }
            
        }
    #endregion
    }

