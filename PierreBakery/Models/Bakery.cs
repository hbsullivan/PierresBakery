namespace PierreBakery
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
      for (int i=0; i < BreadNumber; i++)
      {
        if ((i % 3) == 0)
        {
          counter += 0;
        } else{
          counter += 5;
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
  }
}