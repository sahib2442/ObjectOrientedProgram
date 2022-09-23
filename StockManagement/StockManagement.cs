using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace ObjectOriendedProgram.StockManagement
{
    public class StockManagement
    {
        List<Stock> stockList = new List<Stock>();
        List<Company> companyList = new List<Company>();
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
        public void ReadJsonFileCompany(string fileName, JsonConvert JsonConvert)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                this.companyList = JsonConvert.DeserializeObject<List<Stock>>(json);
                Console.WriteLine("Name" + "\t" + "No Of Shares" + "\t" + "Price Per Share");
                foreach (var data in companyList)
                {
                    Console.WriteLine(data.Symbol + "\t" + data.NoOfShares + "\t" + data.PricePerShare);
                }
            }
        }
        public void BuyCompanyShares(Company company)
        {
            bool flag = false;
            foreach (var stockDetails in stockList)
            {
                if (stockDetails.Name == company.Symbol)
                {
                    stockDetails.NoOfShares += company.NoOfShares;
                }
            }
            foreach (var stockDetails in stockList)
            {
                if (stockDetails.Name == company.Symbol)
                {
                    stockDetails.NoOfShares += company.NoOfShares;
                    flag = true;
                }
            }
            if (!flag)
            {
                Stock stock = new Stock();
                stock.Name = company.Symbol;
                stock.NoOfShares = company.NoOfShares;
                stock.PricePerShare = company.PricePerShare;
                stockList.Add(stock); 
            }
        }
        public void WriteToJsonStock(string filePath)
        {
            var json = JsonConvert.SerializeObject(this.stockList);
            File.WriteAllText(filePath, json);
        }
        public void WriteToJsonCompany(string filePath)
        {
            var json = JsonConvert.SerializeObject(this.companyList);
            File.WriteAllText(json, filePath);
        }
    }
}
