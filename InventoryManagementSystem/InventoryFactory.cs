using Newtonsoft.Json;
using ObjectOriendedProgram.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ObjectOriendedProgram.InventoryManagementSystem
{
    public class InventoryFactory : InventoryFactoryBase
    {
        InventoryManagement inventory = new InventoryManagement();
        public void ReadJsonFile(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                this.inventory = JsonConvert.DeserializeObject<InventoryManagement>(json);
                Display(this.inventory.RiceList, "RiceList");
                Display(this.inventory.WheatList, "WheatList");
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }

        public void WriteToJson(string filePath)
        {
            var json = JsonConvert.SerializeObject(this.inventory);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
        }
        public void Display(List<InventoryDetails> list,string inventoryName)
        {
            Console.WriteLine("Inventory is:"+inventoryName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "Price");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price);
            }
        }
    }
}
