using System;

namespace FactoryMethodPattern
{
    public class TransformerPumpFactory : TransformerFactory
    {
        public override ITransformer CreateTransformer()
        {
            Console.WriteLine("PumpFactory produce transformer pump!");
            return new TransformerPump();
        }
    }
}
