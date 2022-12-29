using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment
{
    public class Management
    {
        double amount = 1000;
        List<Details> stock = new List<Details>();
        List<Details> customer = new List<Details>();
        public void ReadStockJsonFile(string filePath)
        {
            this.stock = JsonConvert.DeserializeObject<List<Details>>(json);
            Console.WriteLine("StockName  StockPrice  NoOfShares");
            foreach (var content in stock)
            {
                Console.WriteLine(content.StockName + "   " + content.StockPrice + "   " + content.NoOfShares);
            }
        }
        public void ReadCustomerJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            this.customer = JsonConvert.DeserializeObject<List<Details>>(json);
            Console.WriteLine("Contains:\n1)StockName  \n2)StockPrice  \n3)NoOfShares");
            foreach (var content in customer)
            {
                Console.WriteLine(content.StockName + "   " + content.StockPrice + "   " + content.NoOfShares);
            }
        }
        public void BuyStock(string name)
        {
            foreach (var data in stock)
            {
                int count = 0;
                if (data.StockName.Equals(name))
                {
                    Console.WriteLine("Enter required stocks you want to buy");
                    int noOfStocks = Convert.ToInt32(Console.ReadLine());
                    if (noOfStocks * data.StockPrice <= amount && noOfStocks <= data.NoOfShares)
                    {
                        Details details = new Details()
                        {
                            StockName = data.StockName,
                            StockPrice = data.StockPrice,
                            NoOfShares = noOfStocks
                        };
                        data.NoOfShares -= noOfStocks;
                        amount -= data.StockPrice * noOfStocks;
                        foreach (var account in customer)
                        {
                            if (account.StockName.Equals(name))
                            {
                                count++;
                            }
                        }
                        if (count == 1)
                        {
                            data.NoOfShares += noOfStocks;
                        }
                        else
                        {
                            customer.Add(details);
                        }
                    }
                }
            }
        }
        public void WriteToStockJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(stock);
            File.WriteAllText(filePath, json);
        }
        public void WriteToCustomerJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(customer);
            File.WriteAllText(filePath, json);
        }
    }
}
