using System;
using PierreBakery.Models;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have Bread ($5/loaf) and Pastries ($2/pastry) available.");
      Console.WriteLine("Check out our deals!");
      Console.WriteLine("Buy 2 loaves of bread, get 1 free!");
      Console.WriteLine("3 Pastries for $5!");

      Console.WriteLine("How many loaves of bread do you want?");
      string stringBreadNumber = Console.ReadLine();
      Bread newBread = new Bread(stringBreadNumber);
      Console.WriteLine("The price of your bread is $" + newBread.BreadPrice());

      Console.WriteLine("How many pastries would you like?");
      string stringPastryNumber = Console.ReadLine();
      Pastry newPastry = new Pastry(stringPastryNumber);
      Console.WriteLine("The price of your pastries is $" + newPastry.PastryPrice());

      Console.WriteLine("The total price of your order is $" + (newBread.BreadPrice()+newPastry.PastryPrice()));

      Console.WriteLine("Would you like to place another order? [Y]/[N]");
      string response = Console.ReadLine().ToLower();
      if (response == "y")
      {
        Main();
      } else 
      {
        Console.WriteLine("Thank you for coming to Pierre's! Goodbye!");
      }
    }
  }
}