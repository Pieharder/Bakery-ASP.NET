using System.Collections.Generic;

namespace Bakery.Model
{
  public class BakeryProducts
  {
    private static List<Item> _items = new List<Item>();

    public static List<Item> Items
    {
      get
      { return _items; }

    }

    public static void AddToList(Item product)
    {
      _items.Add(product);
    }

  }

  public class Item : BakeryProducts
  {
    public string Type { get; set; }
    public string Kind { get; set; }
    public string Amount { get; set; }

    public Item(string type, string kind, string amount)
    {
      Type = type;
      Kind = kind;
      Amount = amount;
      BakeryProducts.Items.Add(this);
    }


  }



}