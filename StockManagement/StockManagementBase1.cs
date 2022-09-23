using Newtonsoft.Json;

namespace ObjectOriendedProgram.StockManagement
{
    public class StockManagementBase1
    {
        public void ReadJsonFileCompany(string fileName, JsonConvert jsonConvert)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                this.companyList = jsonConvert.DeserializeObject<List<Stock>>(json);
                Console.WriteLine("Name" + "\t" + "No Of Shares" + "\t" + "Price Per Share");
                foreach (var data in companyList)
                {
                    Console.WriteLine(data.Symbol + "\t" + data.NoOfShares + "\t" + data.PricePerShare);
                }
            }
        }
        public void ReadJsonFileStock(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                this.stockList = JsonConvert.DeserializeObject<List<Stock>>(json);
                Console.WriteLine("Name" + "\t" + "No Of Shares" + "\t" + "Price Per Share");
                foreach (var data in stockList)
                {
                    Console.WriteLine(data.Name + "\t" + data.NoOfShares + "\t" + data.PricePerShare);
                }
            }
        }
    }
}