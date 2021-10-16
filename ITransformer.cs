namespace FactoryMethodPattern
{
    public interface ITransformer
    {
        // It is important to the same product interface, with different product implementation.
        void GetVoltage();
    }
}
