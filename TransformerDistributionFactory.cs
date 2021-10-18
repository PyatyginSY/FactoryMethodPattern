using System;

namespace FactoryMethodPattern
{
    internal class TransformerDistributionFactory : TransformerFactory
    {
        public override ITransformer CreateTransformer()
        {
            Console.WriteLine("DistributionFactory produce transformer distribution!");
            return new TransformerDistribution();
        }
    }
}
