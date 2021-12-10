namespace Bakery.Models
{
  public class Pastry
  { 
    public int PastryAmount {get; set; }
    public int PastryPrice  { get; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      PastryPrice = 2;
    }

    public int PastryCost()
    {
      if (PastryAmount >= 3 )
      {
        int cost = (PastryAmount * PastryPrice) - (PastryAmount / 3);
        return cost;
      }
      else
      {
        int cost = (PastryAmount * PastryPrice);
        return cost;
      }
    }

  }
}

//Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
