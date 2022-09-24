namespace design_pattern.builder
{
    internal class Builder : IBuilder
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public IBuilder SetDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public IBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}
