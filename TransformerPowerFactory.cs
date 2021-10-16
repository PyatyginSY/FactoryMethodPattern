namespace FactoryMethodPattern
{
    internal class TransformerPowerFactory : ITransformerFactory
    {
        public ITransformer CreateTransformer()
        {
            return new TransformerPower();
        }
    }
}
