using System;
using System.Collections.Generic;
using Bakery.Models;  //import namespaces from PierresBakery

class Program
{
  public static void Main()
  {
    Console.WriteLine("_____________________________________________________________________________\n");
    Console.WriteLine("Welcome to Pieerie's Bakery shop. We Made fresh bakeries with love everyday");
    Console.WriteLine("-----------------------------------------------------------------------------\n");
    Console.WriteLine("First  :  We have Bread a single loaf is $5 \n ** Promotion now! Buy 2 get 1 Free!! **");
    Console.WriteLine("--------------------------------------------------\n");
    Console.WriteLine("Second :  We have some pastries for $2 each \n ** Promotion now! 3 Pastries for $5 ** ");
    Console.WriteLine("--------------------------------------------------\n");
    Console.WriteLine("How many Bread would you like to get?");
    string FirstOrder = Console.ReadLine();
    int breadOrder = int.Parse(FirstOrder);
    Bread newBread = new Bread(breadOrder);
    int BreadCost = newBread.BreadCost();
    Console.WriteLine("How many Pastry would you like to get?");
    string SecondOrder = Console.ReadLine();
    int pastryOrder = int.Parse(SecondOrder);
    Pastry newPastry = new Pastry(pastryOrder);
    int PastryCost = newPastry.PastryCost();
    
    int totalCost = BreadCost + PastryCost;
    Console.WriteLine($"Your order total is {totalCost} dollars");
  }
}

