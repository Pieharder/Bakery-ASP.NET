using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery.Model;

namespace Bakery.View
{
  class PastryMenu
  {
    public static void Print()
    {
      Console.Clear();
      Console.WriteLine(@"
      =========================================================================================
      .______      ___           _______..___________..______       __   _______      _______.
      |   _  \    /   \         /       ||           ||   _  \     |  | |   ____|    /       |
      |  |_)  |  /  ^  \       |   (----``---|  |----`|  |_)  |    |  | |  |__      |   (----`
      |   ___/  /  /_\  \       \   \        |  |     |      /     |  | |   __|      \   \    
      |  |     /  _____  \  .----)   |       |  |     |  |\  \----.|  | |  |____ .----)   |   
      | _|    /__/     \__\ |_______/        |__|     | _| `._____||__| |_______||_______/    
     =========================================================================================
", Color.Cyan);
      StyleSheet styleSheet = new StyleSheet(Color.Green);
      styleSheet.AddStyle("1[1-9]*", Color.Red);
      styleSheet.AddStyle("2[1-9]*", Color.Cyan);
      styleSheet.AddStyle("3[1-9]*", Color.Yellow);
      styleSheet.AddStyle("4[1-9]*", Color.Yellow);
      styleSheet.AddStyle("M[A-Z]*", Color.White);

      //Menu string
      string Menu = (@"
        | [1] + Baklava        | 
        | [2] + Cream Horn     | 
        | [3] + Croissant      |
        | [4] + Fig Roll       |
        | [M]   Main Menu      |
        ");
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.Write("Enter : ", Color.Green);
    }
  }

  class PastryMessage
  {
    public static void HowMany(string pastryType)
    {
      Console.WriteLine("      ====================================================", Color.Pink);
      Console.WriteLine($"      How many {pastryType} would you like", Color.Green);
      Console.Write("      Enter : ");
    }

    public static void Confirm(int count, string pastryType)
    {
      Console.WriteLine();
      Console.WriteLine($"      Added {count} {pastryType} to your cart", Color.Green);
      Console.Write("      Continue : ");
    }

    public static void Error()
    {
      Console.WriteLine("      Could not add item to cart");
      Console.Write("      Continue : ");
    }
  }
}