using System;

namespace interpolated
{
    public class Vegetable
    {
      public Vegetable(string name) => Name = name;

      public string Name { get; }

      public override string ToString() => Name;
    }

    public class Program
    {
      public enum Unit { item, kilogram, gram, dozen };

      public static void Main()
      {
        var item = new Vegetable("eggplant");
        var date = DateTime.Now;
        var price = 1.99m;
        var unit = Unit.item;
        Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");
      }
    }
    
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var name = "Paul";
    //        Console.WriteLine($"Hello, {name}. It's a pleasure to meet you");
    //    }
    //}
}
