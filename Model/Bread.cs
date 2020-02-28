using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery;

namespace Bakery.Model
{
  class Bread
  {
    public string BreadType { get; set; }
    public int BreadCount { get; set; }
    Bread(string type, int count)
    {
      BreadType = type;
      BreadCount = count;
    }
    public static void Menu()
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
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "1":
          AddBreadToCart("Wheat");
          Bread.Menu();
          break;

        case "2":
          AddBreadToCart("White");
          Bread.Menu();
          break;

        case "3":
          AddBreadToCart("9 Grain");
          Bread.Menu();
          break;

        case "4":
          AddBreadToCart("Rye");
          Bread.Menu();
          break;

        case "m":
          break;

        default:
          Bread.Menu();
          break;
      }

    }

    public static void AddBreadToCart(string breadName)
    {
      Console.WriteLine($"How many loafs of {breadName} bread would you like");
      Console.Write("Enter : ");
      string input = Console.ReadLine();
      int count;

      bool success = int.TryParse(input, out count);

      if (success)
      {
        Bread bread = new Bread(breadName, count);
        // cart.AddBread(bread);
        Cart.BreadCart.Add(bread);
        Console.WriteLine($"Added {count} loafs of {breadName} bread to your cart", Color.Green);
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