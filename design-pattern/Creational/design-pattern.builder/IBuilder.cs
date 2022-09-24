namespace design_pattern.builder
{
    internal interface IBuilder
    {
        IBuilder SetName(string name);
        IBuilder SetDescription(string description);
    }
}
