using System;
using System.Collections.Generic;
using Bakery.Models;  //import namespaces from PierresBakery

class Program
{
  public static void Main()
  {
    Console.WriteLine("_____________________________________________________________________________\n");
    Console.WriteLine("Welcome to Pierre's Bakery shop. We would love you to try our handmade bakery");
    Console.WriteLine("");
    Console.WriteLine("______________Fresh______________Bakery______________Everyday________________\n");
    Console.WriteLine(""); 
    Console.WriteLine("First  :  We have Bread a single loaf is $5 \n  \n ** Promotion now! Buy 2 get 1 Free!! **");
    Console.WriteLine("--------------------------------------------------\n");
    Console.WriteLine("Second :  We have Pastry for $2 each \n     \n ** Promotion now! 3 Pastries for $5 ** ");
    Console.WriteLine("--------------------------------------------------\n");
    Console.WriteLine("How many 'Bread' would you like to get?");
    int breadOrder= int.Parse(Console.ReadLine());
    Bread newBread = new Bread(breadOrder);
    int breadCost = newBread.BreadCost();

    Console.WriteLine("How many 'Pastry' would you like to get?");
    int pastryOrder = int.Parse(Console.ReadLine());
    Pastry newPastry = new Pastry(pastryOrder);
    int pastryCost = newPastry.PastryCost();

    int total = breadCost + pastryCost;
    Console.WriteLine($"Your order is {breadOrder} Bread(s) {pastryOrder}, Pastries and the total is ${total}");
    Console.WriteLine("");
    Console.WriteLine($"Thank you for your support! We hope to see you again soon!");
  }
}

  