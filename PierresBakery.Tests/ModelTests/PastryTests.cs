using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
      public void Pastry_CreateNewInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(typeof(Pastry) , newPastry.GetType());
      }
    
    [TestMethod]
      public void Pastry_GetAmountOfPastry_Int()
      {
        int pastryAmount = 3;
        Pastry newPastry = new Pastry(pastryAmount);
        int amount = newPastry.PastryAmount;
        Assert.AreEqual(pastryAmount, amount);
      }

    [TestMethod]
      public void Pastry_SetChangeAmountOfPastry_Int()
      {
        int pastryAmount = 3;
        Pastry newPastry = new Pastry(pastryAmount);
        int pastryAmountChange = 10;
        newPastry.PastryAmount = pastryAmountChange;
        int amount = pastryAmountChange;
        Assert.AreEqual(pastryAmountChange, amount);
      }

    [TestMethod]
      public void Pastry_GetPastryPrice_Int()
      {
        int pastryPrice = 2;
        Pastry newpastry = new Pastry(pastryPrice);
        int price = newpastry.PastryPrice;
        Assert.AreEqual(pastryPrice, price);
      }




  }
}