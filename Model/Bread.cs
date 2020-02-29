
using Console = Colorful.Console;
using Bakery.View;

namespace Bakery.Model
{
  class Bread
  {
    /////////////////////////////////////
    //////    Properties     ///////////
    public string BreadType { get; set; }
    public int BreadCount { get; set; }

    /////////////////////////////////////
    //////    Constructor   ///////////
    Bread(string type, int count)
    {
      BreadType = type;
      BreadCount = count;
    }

    /////////////////////////////////////
    //////     Methods      ////////////
    public static void Menu()
    {
      BreadMenu.Print();
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
      BreadPrintMessage.HowMany(breadName);
      string input = Console.ReadLine();
      int count;

      bool success = int.TryParse(input, out count);

      if (success)
      {
        Bread bread = new Bread(breadName, count);
        // cart.AddBread(bread);
        Cart.BreadCart.Add(bread);
        BreadPrintMessage.Confirm(count, breadName);
        Console.ReadLine();
      }
      else
      {
        BreadPrintMessage.ErrorMessage();
        Console.ReadLine();
      }


    }

  }
}