using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery.Model
{
  class Cart
  {
    private static List<Bread> breadCart = new List<Bread>(5);
    public static List<Bread> BreadCart
    {
      get { return breadCart; }
      set { breadCart = value; }
    }
    private static List<Pastry> pastryCart = new List<Pastry>(5);
    public static List<Pastry> PastryCart
    {
      get { return pastryCart; }
      set { pastryCart = value; }
    }


    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine(@"

                          =================================================
                            ______      ___      .______     .___________.
                           /      |    /   \     |   _  \    |           |
                          |  ,----'   /  ^  \    |  |_)  |   `---|  |----`
                          |  |       /  /_\  \   |      /        |  |     
                          |  `----. /  _____  \  |  |\  \----.   |  |     
                           \______|/__/     \__\ | _| `._____|   |__|     
                         ================================================= 
                                                                          
      ", Color.Red);

      StyleSheet styleSheet = new StyleSheet(Color.Green);
      styleSheet.AddStyle("1[1-9]*", Color.Red);
      styleSheet.AddStyle("2[1-9]*", Color.Cyan);
      styleSheet.AddStyle("M[A-Z]", Color.White);

      //Menu string
      string Menu = (@"
        | [1] Checkout                 | 
        | [2] See Daily Deals          |
        | [M] Main Menu                |
        ");

      PrintItems();
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();


      switch (input)
      {
        case "1":
          CheckOut();
          Cart.Menu();
          break;

        case "2":
          AddDailyDeal();
          Cart.Menu();
          break;

        case "m":
          break;

        default:
          Cart.Menu();
          break;
      }
    }

    public static void AddDailyDeal()
    {
      Console.Clear();
      Console.WriteLine(@"

                      ========================================================
                         _______       ___       __   __      ____    ____ 
                        |       \     /   \     |  | |  |     \   \  /   / 
                        |  .--.  |   /  ^  \    |  | |  |      \   \/   /  
                        |  |  |  |  /  /_\  \   |  | |  |       \_    _/   
                        |  '--'  | /  _____  \  |  | |  `----.    |  |     
                        |_______/ /__/     \__\ |__| |_______|    |__|     
                                                                           
                       _______   _______      ___       __           _______.
                      |       \ |   ____|    /   \     |  |         /       |
                      |  .--.  ||  |__      /  ^  \    |  |        |   (----`
                      |  |  |  ||   __|    /  /_\  \   |  |         \   \    
                      |  '--'  ||  |____  /  _____  \  |  `----..----)   |   
                      |_______/ |_______|/__/     \__\ |_______||_______/    
                    ===========================================================                                                                                      
      ", Color.Red);
      Console.WriteLine("Daily deal");
      Console.Write("Enter : ");
      string input = Console.ReadLine();
    }


    public static void PrintItems()
    {
      int loafCount = 0;
      int pastryCount = 0;

      //get line item counts
      foreach (Bread item in BreadCart)
      {
        loafCount += item.BreadCount;
      }
      foreach (Pastry item in PastryCart)
      {
        pastryCount += item.PastryCount;
      }

      //print bread
      Console.WriteLine($"You have {loafCount} loafs of bread in your cart.");
      foreach (Bread item in BreadCart)
      {
        Console.WriteLine($"[- [{item.BreadCount}] {item.BreadType} -]");

      }

      //print pastry
      Console.WriteLine($"You have {pastryCount} pastries in your cart.");
      foreach (Pastry item in PastryCart)
      {
        Console.WriteLine($"[- [{item.PastryCount}] {item.PastryType} -]");

      }


    }

    public static void CheckOut()
    {
      Console.Clear();
      Console.WriteLine(@"
         ===================================================================================
           ______  __    __   _______   ______  __  ___   ______    __    __  .___________.
          /      ||  |  |  | |   ____| /      ||  |/  /  /  __  \  |  |  |  | |           |
         |  ,----'|  |__|  | |  |__   |  ,----'|  '  /  |  |  |  | |  |  |  | `---|  |----`
         |  |     |   __   | |   __|  |  |     |    <   |  |  |  | |  |  |  |     |  |     
         |  `----.|  |  |  | |  |____ |  `----.|  .  \  |  `--'  | |  `--'  |     |  |     
          \______||__|  |__| |_______| \______||__|\__\  \______/   \______/      |__|     
        ====================================================================================                                                                                     
      ", Color.Green);
      string input = Console.ReadLine();
    }

  }

}
