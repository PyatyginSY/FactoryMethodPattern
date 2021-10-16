using System;

namespace FactoryMethodPattern
{
    class TransformerFactory
    {
        public ITransformer GetTransformer(string typeTransformer)
        {
            var transformerFactory = (ITransformerFactory)Activator.CreateInstance(Type.GetType("FactoryMethodPattern." + typeTransformer.ToString() + "Factory"));
            return transformerFactory.CreateTransformer();
        }
    }
}
