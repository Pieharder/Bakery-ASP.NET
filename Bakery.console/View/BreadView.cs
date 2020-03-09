using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery.Model;

namespace Bakery.View
{
  class BreadMenu
  {
    public static void Print()
    {
      Console.Clear();
      Console.WriteLine(@"

                      ========================================================
                      .______   .______       _______      ___       _______  
                      |   _  \  |   _  \     |   ____|    /   \     |       \ 
                      |  |_)  | |  |_)  |    |  |__      /  ^  \    |  .--.  |
                      |   _  <  |      /     |   __|    /  /_\  \   |  |  |  |
                      |  |_)  | |  |\  \----.|  |____  /  _____  \  |  '--'  |
                      |______/  | _| `._____||_______|/__/     \__\ |_______/ 
                     =========================================================
      ", Color.Red);

      StyleSheet styleSheet = new StyleSheet(Color.Green);
      styleSheet.AddStyle("1[1-9]*", Color.Red);
      styleSheet.AddStyle("2[1-9]*", Color.Cyan);
      styleSheet.AddStyle("3[1-9]*", Color.Yellow);
      styleSheet.AddStyle("4[1-9]*", Color.Yellow);
      styleSheet.AddStyle("M[A-Z]*", Color.White);

      //Menu string
      string Menu = (@"
        | [1] + Wheat bread loaf      | 
        | [2] + White bread loaf      | 
        | [3] + 9 Grain bread loaf    |
        | [4] + Rye bread loaf        |
        | [M]   Main Menu             |
        ");
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.WriteLine();
      Console.Write("        Enter : ", Color.Green);
    }
  }

  class BreadPrintMessage
  {
    public static void HowMany(string breadName)
    {
      Console.WriteLine("      ====================================================", Color.Pink);
      Console.WriteLine($"      How many loaves of {breadName} bread would you like", Color.Green);
      Console.Write("      Enter : ");
    }

    public static void Confirm(int count, string breadName)
    {
      string loaves = "loaves";
      if (count == 1)
      {
        loaves = "loaf";
      }
      Console.WriteLine();
      Console.WriteLine($"      Added {count} {loaves} of {breadName} bread to your cart", Color.Green);
      Console.Write("      Continue : ");
    }

    public static void ErrorMessage()
    {
      Console.WriteLine("      Could not add item to cart");
      Console.Write("      Continue : ");
    }
  }
}