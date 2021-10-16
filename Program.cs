using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethodPattern");
            var power = new TransformerFactory().GetTransformer("TransformerPower");
            power.GetVoltage();
            var distribution = new TransformerFactory().GetTransformer("TransformerDistribution");
            distribution.GetVoltage();
            var pump = new TransformerFactory().GetTransformer("TransformerPump");
            pump.GetVoltage();
            Console.ReadLine();
        }
    }
}
