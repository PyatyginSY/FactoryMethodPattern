using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethodPattern");

            TransformerFactory factory;
            ITransformer transformer;

            factory = new TransformerPowerFactory();
            factory.TransformerFactoryMessage();
            transformer = factory.CreateTransformer();
            transformer.GetVoltage();

            factory = new TransformerDistributionFactory();
            factory.TransformerFactoryMessage();
            transformer = factory.CreateTransformer();
            transformer.GetVoltage();

            factory = new TransformerPumpFactory();
            factory.TransformerFactoryMessage();
            transformer = factory.CreateTransformer();
            transformer.GetVoltage();

            Console.ReadLine();
        }
    }
}
