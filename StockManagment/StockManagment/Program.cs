namespace StockManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stock Inventory Management program\n");
            Management management = new Management();
            string stockFilePath = (@"E:\Visual Studio\.Net\JSON_Inventory\StockManagment\StockManagment");
            management.ReadStockJsonFile(stockFilePath);
            string customerFilePath = (@"E:\Visual Studio\.Net\JSON_Inventory\StockManagment\StockManagment");
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Infosys");
            management.WriteToStockJsonFile(stockFilePath);
            management.WriteToStockJsonFile(customerFilePath);
        }
    }
}