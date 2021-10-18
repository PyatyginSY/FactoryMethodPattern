using System;

namespace FactoryMethodPattern
{
    public class TransformerPowerFactory : TransformerFactory
    {
        public override ITransformer CreateTransformer()
        {
            Console.WriteLine("PowerFactory produce transformer power!");
            return new TransformerPower();
        }
    }
}
