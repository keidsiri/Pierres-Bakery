namespace PierresBakery.Models
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



  }
}