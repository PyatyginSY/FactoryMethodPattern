using System;

namespace FactoryMethodPattern
{
    internal class TransformerPowerFactory : TransformerFactory
    {
        public override ITransformer CreateTransformer()
        {
            Console.WriteLine("PowerFactory produce transformer power!");
            return new TransformerPower();
        }
    }
}
