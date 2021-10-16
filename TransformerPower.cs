using System;

namespace FactoryMethodPattern
{
    public class TransformerPower : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer power");
        }
    }
}
