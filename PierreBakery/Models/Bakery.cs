namespace PierreBakery
{
  public class Bread
  {
    public int BreadNumber { get; }

    public Bread(string stringBreadNumber)
    {
      BreadNumber = int.Parse(stringBreadNumber);
    }
  }

  public class Pastry
  {
    
  }
}