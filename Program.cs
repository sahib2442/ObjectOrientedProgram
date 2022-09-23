using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ObjectOriendedProgram.InventoryManagement;
using ObjectOriendedProgram.StockManagement;

namespace ObjectOriendedProgram.InventoryManagementSystem
{
    class program
    {
        private static readonly string? INVENTORY_DATA_FILE_PATH;
        private static InventoryDetails? details;
        private static string? Name;
        private static int Weight;
        private static int Price;

        public static string? STOCK_DATA_FILE_PATH { get; private set; }
        public static object? COMPANY_DATA_FILE_PATH { get; private set; }
        public static string? Symbol { get; private set; }
        public static int NoOfShares { get; private set; }
        public static int PricePerShare { get; private set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("1.Display Inventory\n2.Inventory Management\n3.Stock Acount Management\n");
            Console.WriteLine("Please enter your choice");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("        Display Inventory         \n");
                    InventoryFactory inventory = new InventoryFactory();
                    inventory.ReadJsonFile(filePath: INVENTORY_DATA_FILE_PATH);
                    break;
                case 1:
                    Console.WriteLine("        Inventory Management       \n");
                    InventoryFactory inventoryFactory = new InventoryFactory();
                    inventoryFactory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                    {
                        Name = "abc";
                        Weight = 20;
                        Price = 25;
                    };
                    inventoryFactory.AddInventory("RiceList", details);
                    break;
                case 3:
                    Console.WriteLine("                   Stock Account Management             \n");
                    CreateStock createStock = new CreateStock();
                    createStock.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                    break;
                case 4:
                    StockManagementBase stockManagement = new StockManagementBase();
                    stockManagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                    stockManagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                    Company company = new Company();
                    {
                        Symbol = "FaceBook";
                        NoOfShares = 10;
                        PricePerShare = 20;
                    };
                    stockManagement.BuyCompanyShare(company);
                    stockManagement.WriteToJsonStock(STOCK_DATA_FILE_PATH);
                    stockManagement.WriteToJsonCompany(COMPANY_DATA_FILE_PATH);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
