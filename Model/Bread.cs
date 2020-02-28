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
      Console.WriteLine("Bread Menu");

    }

    public static void AddBreadToCart(string breadType, int count)
    {
      Bread bread = new Bread(breadType, count);
      cart.BreadCart.Add(bread);

    }

  }
}