using design_pattern.factory_abstract.AbstractCreator;
using design_pattern.factory_abstract.ConcreteCreator;

namespace design_pattern.factory_abstract
{
    internal class Factory : IFactory
    {
        public ICreatorEpilog CreateEpilog()
        {
           return new Epilog();
        }

        public ICreatorProlog CreateProlog()
        {
            return new Prolog();
        }
    }
}
