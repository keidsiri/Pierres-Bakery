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

    
  }
}