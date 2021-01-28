using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;
    string password;
    //Screen enumeration
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

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
            if( input == "1" )
            {
                level = 1;
                password = "password";
                StartGame();
            }
            else if( input == "2"  )
            {
                level = 2;
                password = "password2";
                StartGame();            
            }
            else if( input == "3"  )
            {
                level = 3;
                password = "password3";
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
            Terminal.WriteLine("You selected level " + level);
            Terminal.WriteLine("Password:");
        } 
    #endregion
    #region CheckPassword
        void CheckPassword(string input)
        {
            if ( input == password )
            {
                Terminal.WriteLine("Access Granted");
            }
            else
            {
                Terminal.WriteLine("Wrong Password");
            }
        }
    #endregion
    void Update()
    {

    }
    }

