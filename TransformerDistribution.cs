using System;

namespace FactoryMethodPattern
{
    public class TransformerDistribution : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer distribution");
        }
    }
}
