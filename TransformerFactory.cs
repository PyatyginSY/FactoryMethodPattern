using System;

namespace FactoryMethodPattern
{
    public abstract class TransformerFactory
    {
        public void TransformerFactoryMessage()
        {
            Console.WriteLine("Factory produce transformer!");
        }

        public abstract ITransformer CreateTransformer();
    }
}
