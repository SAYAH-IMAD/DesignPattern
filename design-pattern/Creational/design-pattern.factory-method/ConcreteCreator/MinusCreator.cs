using design_pattern.factory_method.Operation;

namespace design_pattern.factory_method.ConcreteCreator
{
    internal class MinusCreator : Creator
    {
        public override IOperation FactoryMethod()
        {
            return new Minus();
        }
    }
}
