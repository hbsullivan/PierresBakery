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
      Bread newBread = new Bread();
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
      int breadNumber = int.Parse(stringBreadNumber);
      Bread newBread = new Bread();
      string result = newBread.BreadNumber;
      Assert.AreEqual(breadNumber, result);
    }
  }
}