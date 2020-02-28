using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery.View;


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

      string input = CartMenu.Print();

      switch (input)
      {
        case "1":
          CartCheckout.Print();
          Cart.Menu();
          break;

        case "2":
          DailyDeal.Print();
          Cart.Menu();
          break;

        case "m":
          break;

        default:
          Cart.Menu();
          break;
      }
    }


    public static void PrintItems()
    {
      double loafCount = 0;
      double pastryCount = 0;

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
      Console.WriteLine($"Your total with 'Buy one get one free' is ${getBreadTotal(loafCount)}");

      //print pastry
      Console.WriteLine($"You have {pastryCount} pastries in your cart.");
      foreach (Pastry item in PastryCart)
      {
        Console.WriteLine($"[- [{item.PastryCount}] {item.PastryType} -]");

      }
      Console.WriteLine($"Your total with 'Buy one get one free' is ${getPastryTotal(pastryCount)}");


    }

    static double getBreadTotal(double loafCount)
    {
      double result;
      if (loafCount > 2)
      {
        result = (loafCount - (loafCount / 3)) * 5;
      }
      else
      {
        result = loafCount * 5;
      }

      return result;
    }
    static double getPastryTotal(double pastryCount)
    {
      double result;
      if (pastryCount > 2)
      {
        result = (pastryCount - ((pastryCount / 3) / 2)) * 2;
      }
      else
      {
        result = pastryCount * 2;
      }

      return result;
    }



  }

}
