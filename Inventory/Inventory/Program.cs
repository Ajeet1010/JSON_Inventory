namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation json = new Operation();
            json.ReadJsonFile(@"E:\Visual Studio\.Net\JSON_Inventory\Inventory");
        }
    }
}