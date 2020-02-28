using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery.Model
{
  class Pastry
  {
    public string PastryType { get; set; }
    public int PastryCount { get; set; }
    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine(@"
      
.______      ___           _______.___________..______     ____    ____ 
|   _  \    /   \         /       |           ||   _  \    \   \  /   / 
|  |_)  |  /  ^  \       |   (----`---|  |----`|  |_)  |    \   \/   /  
|   ___/  /  /_\  \       \   \       |  |     |      /      \_    _/   
|  |     /  _____  \  .----)   |      |  |     |  |\  \----.   |  |     
| _|    /__/     \__\ |_______/       |__|     | _| `._____|   |__|     
                                                                        
.___  ___.  _______ .__   __.  __    __  
|   \/   | |   ____||  \ |  | |  |  |  | 
|  \  /  | |  |__   |   \|  | |  |  |  | 
|  |\/|  | |   __|  |  . `  | |  |  |  | 
|  |  |  | |  |____ |  |\   | |  `--'  | 
|__|  |__| |_______||__| \__|  \______/  
", Color.Cyan);
      StyleSheet styleSheet = new StyleSheet(Color.Green);
      styleSheet.AddStyle("1[1-9]*", Color.Red);
      styleSheet.AddStyle("2[1-9]*", Color.Cyan);
      styleSheet.AddStyle("3[1-9]*", Color.Yellow);
      styleSheet.AddStyle("4[1-9]*", Color.Yellow);
      styleSheet.AddStyle("m[A-Z]*", Color.White);

      //Menu string
      string Menu = (@"
        | [1] +1 Wheat bread loaf      | 
        | [2] +1 White bread loaf      | 
        | [3] +1 9 Grain bread loaf    |
        | [4] +1 Rye bread loaf        |
        | [M] Back to Main Menu        |
        ");
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "1":
          Pastry.Menu();
          break;

        case "2":
          Pastry.Menu();
          break;

        case "3":
          Pastry.Menu();
          break;

        case "4":
          Pastry.Menu();
          break;

        case "m":
          break;

        default:
          Pastry.Menu();
          break;
      }
    }
  }

}