namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }
    public int BreadPrice {get; set;}
    
    public Bread (int breadAmount)
    {
      BreadAmount = breadAmount;
      BreadPrice = 5;
    }

    public int BreadCost()
    {
      if ( BreadAmount >= 3)
      {
        int cost = (BreadAmount * BreadPrice) - ((BreadAmount / 3) * BreadPrice);
        return cost;
      }
      else 
      {
        int cost = BreadAmount * BreadPrice;
        return cost;
      }
    }
  }
}





// promo
// buy 2 get 1 free (every 3rd is free) 
// 1 bread = $5 
// 2 bread = $10
// 3 bread = $10 >> free
// 4 bread = $15
// 5 bread = $20
// 6 bread = $20 >> free

// cost = (amount * price) - ( amount / 3) *  price