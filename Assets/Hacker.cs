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
    #region ShowMainMenu
    void ShowMainMenu()
    {
        Terminal
        Terminal.WriteLine("Want to play a game?");
        Terminal.WriteLine("Let's hack something...");
        Terminal.WriteLine("Press 1 for your local Library");
        Terminal.WriteLine("Press 2 for the local police station");
        Terminal.WriteLine("Enter your selection:");   
    }
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
}
