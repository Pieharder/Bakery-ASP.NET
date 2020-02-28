using Console = Colorful.Console;
using Bakery.View;

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
      PastryMenu.Print();
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

      PastryMessage.HowMany(pastryType);
      string input = Console.ReadLine();
      int count;
      bool success = int.TryParse(input, out count);
      if (success)
      {
        Pastry pastry = new Pastry(pastryType, count);
        // cart.Addpastry(pastry);
        Cart.PastryCart.Add(pastry);
        PastryMessage.Confirm(count, pastryType);
        Console.ReadLine();
      }
      else
      {
        PastryMessage.Error();
        Console.ReadLine();
      }
    }
  }
}