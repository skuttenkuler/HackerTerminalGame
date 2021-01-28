using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;
    void Start()
    {
        ShowMainMenu();
    }
    #region ShowMainMenu
        void ShowMainMenu()
        {
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
        void OnUserInput(string input)
        {
            if( input == "menu")
            {
                ShowMainMenu();
            }
            else if( input == "1" )
            {
                level = 1;
                StartGame();   
            }
            else if( input == "2" )
            {
                level = 2;
                StartGame();
            }
            else if( input == "3"  )
            {
                level = 3;
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
    #endregion
    #region StartGame
        void StartGame()
        {
            Terminal.WriteLine("You selected level " + level);
        } 
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
    }
}
