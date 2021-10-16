namespace FactoryMethodPattern
{
    internal class TransformerDistributionFactory : ITransformerFactory
    {
        public ITransformer CreateTransformer()
        {
            return new TransformerDistribution();
        }
    }
}
