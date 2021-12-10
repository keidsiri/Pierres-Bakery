using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
      public void Bread_CreateInstanceOfBread_Bread()
      {
        Bread newBread = new Bread(20);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }

    [TestMethod]
      public void Bread_GetAmountOfBread_Int()
      {
        int breadAmount = 5;
        Bread newBread = new Bread(breadAmount);
        int amount = newBread.BreadAmount;
        Assert.AreEqual(breadAmount, amount);
      }

    [TestMethod]
      public void Bread_GetBreadPrice_Int()
      {
        int breadPrice = 5;
        Bread newBread = new Bread(breadPrice);
        int price = newBread.BreadPrice;
        Assert.AreEqual(breadPrice, price);
      }

    // [TestMethod]
    //   public void Bread_SetChangeAmountOfBread_Int()
    //   {
    //     int breadAmount = 5;
    //     Bread newBread = new Bread(breadAmount);
    //     int breadAmountChange = 8;
    //     newBread.BreadAmount = breadAmountChange;
    //     int amount = newBread.BreadAmount;
    //     Assert.AreEqual(breadAmountChange, amount);
    //   }




    
  }
}