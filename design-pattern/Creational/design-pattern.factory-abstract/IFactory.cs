using design_pattern.factory_abstract.AbstractCreator;

namespace design_pattern.factory_abstract
{
    internal interface IFactory
    {
        ICreatorEpilog CreateEpilog();
        ICreatorProlog CreateProlog();
    }
}
