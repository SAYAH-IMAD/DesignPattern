using System;
namespace design_pattern.factory_method
{
    internal abstract class Creator
    {
        public abstract IOperation FactoryMethod();

        public void Execute()
        {
            IOperation operation = FactoryMethod();
            operation.Execute();
        }
    }
}
