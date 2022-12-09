using System;
using PierreBakery.Models;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have Bread and Pastries available");

      Console.WriteLine("How many loaves of bread do you want?");
      string stringBreadNumber = Console.ReadLine();
      Bread newBread = new Bread(stringBreadNumber);
      Console.WriteLine("The price of your bread is $" + newBread.BreadPrice());

      Console.WriteLine("How many pastries would you like?");
      string stringPastryNumber = Console.ReadLine();
      Pastry newPastry = new Pastry(stringPastryNumber);
      Console.WriteLine("The price of your pastries is $" + newPastry.PastryPrice());

      Console.WriteLine("The total price of your order is $" + (newBread.BreadPrice()+newPastry.PastryPrice()));

      
    }
  }
}