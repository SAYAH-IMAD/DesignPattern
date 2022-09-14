using design_pattern.factory_method.Operation;

namespace design_pattern.factory_method.ConcreteCreator
{
    internal class AddCreator : Creator
    {
        public override IOperation FactoryMethod()
        {
            return new Add();
        }
    }
}
