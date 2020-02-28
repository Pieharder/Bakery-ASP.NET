using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery.Model;

namespace Bakery.View
{
  class CartMenu
  {
    public static string Print()
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
        | [M] Main Menu                |
        ");

      PrintItems.Print();
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();
      return input;

    }

  }

  class CartCheckout
  {
    public static void Print()
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
      Console.WriteLine($"                Amount of Bread Loafs {Cart.BreadTotal}");
      Console.WriteLine("          ---------------------------------------");
      int thirdFree = 1;
      foreach (Bread item in Cart.BreadCart)
      {
        if (item.BreadCount > 1)
        {
          for (int i = 0; i < item.BreadCount; i++)
          {
            if (thirdFree == 3)
            {
              Console.WriteLine($"                {item.BreadType} --  FREE", Color.Red);
              thirdFree = 1;
            }
            else
            {
              Console.WriteLine($"                {item.BreadType} --  $5");
              thirdFree++;
            }
          }
        }
        if (thirdFree == 3)
        {
          Console.WriteLine($"                {item.BreadType} --  FREE", Color.Red);
          thirdFree = 0;
        }
        else
        {
          Console.WriteLine($"                {item.BreadType} --  $5");
          thirdFree++;
        }
      }
      Console.WriteLine("          ---------------------------------------");
      Console.WriteLine($"                Bread before discount =  ${Math.Round((Cart.BreadTotal * 5), 2)}", Color.Red);
      Console.WriteLine($"                Bead after discout = ${Math.Round(Cart.GetBreadTotal(Cart.BreadTotal), 2)}");
      Console.WriteLine();
      Console.WriteLine("          ---------------------------------------");
      Console.WriteLine("          ---------------------------------------");
      Console.WriteLine($"                Amount of Pastries {Cart.PastryTotal}", Color.Cyan);
      Console.WriteLine("          ---------------------------------------");
      int thirdHalfOff = 1;
      foreach (Pastry item in Cart.PastryCart)
      {
        if (item.PastryCount > 1)
        {
          for (int i = 0; i < item.PastryCount; i++)
          {
            if (thirdHalfOff == 3)
            {
              Console.WriteLine($"                {item.PastryType} --  $1", Color.Red);
              thirdHalfOff = 1;
            }
            else
            {
              Console.WriteLine($"                {item.PastryType} --  $2", Color.Cyan);
              thirdHalfOff++;
            }
          }
        }
        if (thirdHalfOff == 3)
        {
          Console.WriteLine($"                {item.PastryType} --  $1", Color.Red);
          thirdHalfOff = 0;
        }
        else
        {
          Console.WriteLine($"                {item.PastryType} --  $2", Color.Cyan);
          thirdHalfOff++;
        }
      }
      Console.WriteLine();
      Console.WriteLine("          ---------------------------------------");
      Console.WriteLine($"               Pastries before Discount = ${Math.Round((Cart.PastryTotal * 2), 2)}", Color.Red);
      Console.WriteLine($"               Pastries after discount = ${Math.Round(Cart.GetPastryTotal(Cart.PastryTotal), 2)}", Color.Cyan);
      Console.WriteLine("          =======================================");
      Console.WriteLine();
      Console.WriteLine($"                Grand Total ${Math.Round(Cart.GetPastryTotal(Cart.PastryTotal) + Cart.GetBreadTotal(Cart.BreadTotal), 2)}", Color.Red);


      string input = Console.ReadLine();
    }


  }

  class PrintItems
  {

    public static void Print()
    {
      //get line item counts
      foreach (Bread item in Cart.BreadCart)
      {
        Cart.BreadTotal += item.BreadCount;
      }
      foreach (Pastry item in Cart.PastryCart)
      {
        Cart.PastryTotal += item.PastryCount;
      }

      Console.WriteLine("          -------------- [BREAD] -------------------", Color.Red);
      //print bread
      Console.WriteLine($"           Amount of loafs = {Cart.BreadTotal}.");
      foreach (Bread item in Cart.BreadCart)
      {
        Console.WriteLine($"           [ (#{item.BreadCount}) {item.BreadType} ]");

      }
      Console.WriteLine($"           Total before discount =  ${Math.Round((Cart.BreadTotal * 5), 2)}", Color.Red);
      Console.WriteLine($"           Total after discount =  ${Math.Round(Cart.GetBreadTotal(Cart.BreadTotal), 2)}", Color.Green);

      //print pastry
      Console.WriteLine("          -------------- [Pastries] -------------------", Color.Cyan);
      Console.WriteLine($"            Amont of Pastries = {Cart.PastryTotal}.");
      foreach (Pastry item in Cart.PastryCart)
      {
        Console.WriteLine($"            [ (#{item.PastryCount}) {item.PastryType} ]");

      }
      Console.WriteLine($"            Total before Discount = ${Math.Round((Cart.PastryTotal * 2), 2)}", Color.Red);
      Console.WriteLine($"            Total after Discount = ${Math.Round(Cart.GetPastryTotal(Cart.PastryTotal), 2)}", Color.Cyan);
      Console.WriteLine();
      Console.WriteLine("          -------------- [Total] -------------------", Color.Green);
      Console.WriteLine($"            Total after Discount = ${Math.Round(Cart.GetPastryTotal(Cart.PastryTotal) + Cart.GetBreadTotal(Cart.BreadTotal), 2)}", Color.Green);

    }

  }

}