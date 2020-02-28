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

    Pastry(string pastryType, int count)
    {
      PastryType = pastryType;
      PastryCount = count;
    }
    public static void Menu()
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
      string input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "1":
          AddPastryToCart("Baklava");
          Pastry.Menu();
          break;

        case "2":
          AddPastryToCart("Cream Horn");
          Pastry.Menu();
          break;

        case "3":
          AddPastryToCart("Croissant");
          Pastry.Menu();
          break;

        case "4":
          AddPastryToCart("Fig Roll");
          Pastry.Menu();
          break;

        case "m":
          break;

        default:
          Pastry.Menu();
          break;
      }
    }

    public static void AddPastryToCart(string pastryType)
    {
      Console.WriteLine($"How many {pastryType} would you like");
      Console.Write("Enter : ");
      string input = Console.ReadLine();
      int count;

      bool success = int.TryParse(input, out count);
      if (success)
      {
        Pastry pastry = new Pastry(pastryType, count);
        // cart.Addpastry(pastry);
        Cart.PastryCart.Add(pastry);
        Console.WriteLine($"Added {count} {pastryType} to your cart", Color.Green);
        Console.Write("Hit enter to continue : ");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Could not add item to cart");
        Console.Write("Hit enter to continue : ");
        Console.ReadLine();
      }
    }
  }
}