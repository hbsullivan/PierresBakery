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
      
    }
  }
}