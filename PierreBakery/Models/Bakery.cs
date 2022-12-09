namespace PierreBakery.Models
{
  public class Bread
  {
    public int BreadNumber { get; set; }

    public Bread(string stringBreadNumber)
    {
      BreadNumber = int.Parse(stringBreadNumber);
    }

    public int BreadPrice()
    {
      int counter = 0;
      if (BreadNumber <= 2)
      {
        counter = BreadNumber*5;
      } else {
        counter = BreadNumber*5;
      for (int i=1; i < BreadNumber - 1; i+=3)
      {
        counter -= 5;
      }
      }
      return counter;
      
    }

  }

  public class Pastry
  {
    public int PastryNumber { get; set; }

    public Pastry(string stringPastryNumber)
    {
      PastryNumber = int.Parse(stringPastryNumber);
    }

    public int PastryPrice()
    {
      int nonDiscount = (PastryNumber % 3);
      int normalPrice = (nonDiscount) * 2;

      int discount = (PastryNumber - nonDiscount);
      int discountPrice = (discount * 5)/3;
      int pastries = normalPrice + discountPrice;
      
      return pastries;
    }
  }
}