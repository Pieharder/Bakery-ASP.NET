using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery.Model
{
  class cart
  {
    List<int> cartList = new List<int>(5);

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
