using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
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
      Pastry newPastry = new Pastry("3");
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

    [TestMethod]
    public void GetPastryNumber_ReturnPastryNumber_Int()
    {
      string stringPastryNumber = "3";
      Pastry newPastry = new Pastry(stringPastryNumber);
      int pastryNumber = int.Parse(stringPastryNumber);
      int result = newPastry.PastryNumber;
      Assert.AreEqual(pastryNumber, result);
    }

    [TestMethod]
    public void BreadPrice_ReturnBreadPrice_Int()
    {
      string stringBreadNumber = "1";
      Bread newBread = new Bread(stringBreadNumber);
      int expected = 5;
      int result = newBread.BreadPrice();
      Assert.AreEqual(expected, result);
      
    }

      [TestMethod]
    public void BreadPrice_ReturnBreadPriceWithDiscount_Int()
    {
      string stringBreadNumber = "9";
      Bread newBread = new Bread(stringBreadNumber);
      int expected = 30;
      int result = newBread.BreadPrice();
      Assert.AreEqual(expected, result);

    }

    [TestMethod]
    public void PastryPrice_ReturnPriceOfOnePastry_Int()
    {
      string stringPastryNumber = "1";
      Pastry newPastry = new Pastry(stringPastryNumber);
      int expected = 2;
      int result = newPastry.PastryPrice();
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void PastryPrice_ReturnPriceOfPastry_Int()
    {
      string stringPastryNumber = "4";
      Pastry newPastry = new Pastry(stringPastryNumber);
      int expected = 7;
      int result = newPastry.PastryPrice();
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TotalPrice_ReturnTotalPrice_Int()
    {
      string stringPastryNumber = "4";
      Pastry newPastry = new Pastry(stringPastryNumber);
      string stringBreadNumber = "9";
      Bread newBread = new Bread(stringBreadNumber);
      int expected = 37;
      int result = newPastry.PastryPrice() + newBread.BreadPrice(); 
      Assert.AreEqual(expected, result);
    }
  }
}