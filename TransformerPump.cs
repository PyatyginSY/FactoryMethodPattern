using System;

namespace FactoryMethodPattern
{
    public class TransformerPump : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer pump");
        }
    }
}
