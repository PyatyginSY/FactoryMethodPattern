namespace FactoryMethodPattern
{
    internal class TransformerPumpFactory : ITransformerFactory
    {
        public ITransformer CreateTransformer()
        {
            return new TransformerPump();
        }
    }
}
