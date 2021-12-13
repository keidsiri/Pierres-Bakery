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
    string FirstOrder = Console.ReadLine();
    

    if ( FirstOrder == "1"|| FirstOrder == "2" || FirstOrder == "3" || FirstOrder == "4" || FirstOrder == "5" ||
        FirstOrder == "6" || FirstOrder == "7" || FirstOrder == "8" || FirstOrder == "9" || FirstOrder == "0" || FirstOrder == "11" || FirstOrder == "12" || FirstOrder == "13" || FirstOrder == "14" || FirstOrder == "15" || FirstOrder == "16" || FirstOrder == "17" || FirstOrder == "18" || FirstOrder == "19" || FirstOrder == "20" || FirstOrder == "21" || FirstOrder == "22" || FirstOrder == "23" || FirstOrder == "24" || FirstOrder == "25" || FirstOrder == "26" || FirstOrder == "27" || FirstOrder == "28" || FirstOrder == "29" || FirstOrder == "30")
    {
      int breadOrder = int.Parse(FirstOrder);
      Bread newBread = new Bread(breadOrder);
      int BreadCost = newBread.BreadCost();

      Console.WriteLine("How many 'Pastry' would you like to get?");
      string SecondOrder = Console.ReadLine();
      
      if ( SecondOrder  == "1" || SecondOrder  == "2" || SecondOrder == "3" ||SecondOrder  == "4" || SecondOrder == "5" ||
        SecondOrder == "6" || FirstOrder == "7" || FirstOrder == "8" || FirstOrder == "9" || FirstOrder == "0" || FirstOrder == "11" || FirstOrder == "12" || FirstOrder == "13" || FirstOrder == "14" || FirstOrder == "15" || FirstOrder == "16" || FirstOrder == "17" || FirstOrder == "18" || FirstOrder == "19" || FirstOrder == "20" || FirstOrder == "21" || FirstOrder == "22" || FirstOrder == "23" || FirstOrder == "24" || FirstOrder == "25" || FirstOrder == "26" || FirstOrder == "27" || FirstOrder == "28" || FirstOrder == "29" || FirstOrder == "30")
      {
        int pastryOrder = int.Parse(SecondOrder);
        Pastry newPastry = new Pastry(pastryOrder);
        int PastryCost = newPastry.PastryCost();
        int totalCost = BreadCost + PastryCost;
        Console.WriteLine($"Your order total is {totalCost} dollars");
      }
      else
      {
        Console.WriteLine("Would you like to make an order?");
        string answer = Console.ReadLine();
        if ( answer.ToLower() == "yes" || answer.ToLower() == "yeah" || answer.ToLower() == "yea" || answer.ToLower() == "sure")
        {
          Main();
        }
        else 
        {
          Console.WriteLine("We hope to see you soon!");
        }
      }
    }
    else 
    {
      Console.WriteLine("Please only enter the number for your order!!");
      Console.WriteLine("Would you like to make an order?");
      string answer = Console.ReadLine();
      if ( answer.ToLower() == "yes" || answer.ToLower() == "yeah" || answer.ToLower() == "yea" || answer.ToLower() == "sure")
      {
        Main();
      }
      else 
      {
        Console.WriteLine("We hope to see you soon!");
      }
    }

  }
}

    

  