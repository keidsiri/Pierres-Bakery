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
  }
}