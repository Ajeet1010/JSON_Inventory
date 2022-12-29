using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Operation
    {
        public void ReadJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            List<Model> data = JsonConvert.DeserializeObject<List<Model>>(json);
            Console.WriteLine("Name, Weight & Price per kg");
            foreach (var content in data)
            {
                double value = content.priceperkg * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.priceperkg + "   " + value);
            }
        }
    }
}
