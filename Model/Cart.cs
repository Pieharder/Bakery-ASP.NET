using System.Collections.Generic;
using Bakery.View;


namespace Bakery.Model
{
  class Cart
  {
    /////////////////////////////////////////
    ///////////   Bread Fields    ///////////
    private static List<Bread> _breadCart = new List<Bread>(5);
    public static List<Bread> BreadCart
    {
      get { return _breadCart; }
      set { _breadCart = value; }
    }
    public static double BreadTotal { get; set; }

    /////////////////////////////////////////
    ///////////   Pastry Fields    ///////////
    private static List<Pastry> _pastryCart = new List<Pastry>(5);
    public static List<Pastry> PastryCart
    {
      get { return _pastryCart; }
      set { _pastryCart = value; }
    }
    public static double PastryTotal { get; set; }

    /////////////////////////////////////
    //////      Methods     ////////////    
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
          Cart.Menu();
          break;

        case "m":
          break;

        default:
          Cart.Menu();
          break;
      }
    }

    public static double GetBreadTotal(double loafCount)
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
    public static double GetPastryTotal(double pastryCount)
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
