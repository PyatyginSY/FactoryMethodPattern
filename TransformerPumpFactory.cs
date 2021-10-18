using System;

namespace FactoryMethodPattern
{
    internal class TransformerPumpFactory : TransformerFactory
    {
        public override ITransformer CreateTransformer()
        {
            Console.WriteLine("PumpFactory produce transformer pump!");
            return new TransformerPump();
        }
    }
}
