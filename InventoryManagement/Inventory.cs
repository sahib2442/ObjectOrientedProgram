using Newtonsoft.Json;
using ObjectOriendedProgram.StockManagement;
using System;
using System.Collections.Generic;
namespace ObjectOriendedProgram.InventoryManagement
{
    public class StockManagement
    {
        List<InventoryDetails> details = new List<InventoryDetails>();
        public void ReadJsonFileStock(string fileName)
        {
            this.details = JsonConvert.DeserializeObject<List<InventoryDetails>>(fileName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price" + "\t" + "PricePerKg");
            foreach (var data in details)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price);
            }
        }
    }
}

