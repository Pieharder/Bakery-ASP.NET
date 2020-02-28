using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery.Model
{
  class cart
  {
    private static List<Bread> breadCart = new List<Bread>(5);
    public static List<Bread> BreadCart
    {
      get { return BreadCart; }
      set { breadCart = value; }
    }


    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Cart Menu");
    }

    public static void AddDailyDeal()
    {
      Console.Clear();
      Console.WriteLine("Daily deal");
    }

  }

}
