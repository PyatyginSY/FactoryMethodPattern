namespace FactoryMethodPattern
{
    public interface ITransformerFactory
    {
        ITransformer CreateTransformer();
    }
}
