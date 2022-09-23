using System;
namespace ObjectOriendedProgram.StockManagement
{
    public class Company
    {
        public string? Name { get; set; }
        public int NoOfShares { get; set; }
        public int PricePerShare { get; set; }
        public string? Symbol { get; internal set; }
    }
}
    
