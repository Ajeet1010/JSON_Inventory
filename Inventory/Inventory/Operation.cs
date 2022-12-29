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

        // UC2  Inventory Detail Management
        public void ReadJsonFile1(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Model data = JsonConvert.DeserializeObject<Model>(json);
            List<Model> typesOfRice = data.TypesOfRice;
            List<Model> typesOfWheat = data.TypesOfWheat;
            List<Model> typesOfPulses = data.TypesOfPulses;

            // for rice 
            Console.WriteLine("TypeOfRice: ");
            foreach (var content in typesOfRice)
            {
                double value = content.priceperkg * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.priceperkg + "   " + value);
            }

            // for wheat
            Console.WriteLine("TypeOfWheat:");
            foreach (var content in typesOfWheat)
            {
                double value = content.priceperkg * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.priceperkg + "   " + value);
            }

            // for pulses
            Console.WriteLine("TypeOfPulses:");
            foreach (var content in typesOfPulses)
            {
                double value = content.priceperkg * content.Weight;
                Console.WriteLine(content.Name + "   " + content.Weight + "   " + content.priceperkg + "   " + value);
            }
        }
    }
}
