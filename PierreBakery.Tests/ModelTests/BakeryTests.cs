using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery;
using System;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void CreateBreadClass_CreateClass_BreadClass()
    {
      Bread newBread = new Bread("5");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

      [TestMethod]
    public void CreatePastryClass_CreateClass_PastryClass()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetBreadNumber_ReturnsBreadNumber_Int()
    {
      string stringBreadNumber = "5";
      Bread newBread = new Bread(stringBreadNumber);
      int breadNumber = int.Parse(stringBreadNumber);
      int result = newBread.BreadNumber;
      Assert.AreEqual(breadNumber, result);
    }
  }
}