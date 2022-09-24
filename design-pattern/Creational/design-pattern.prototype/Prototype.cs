namespace design_pattern.prototype
{
    internal class Prototype
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Prototype ShallowClone()
        {
            return (Prototype) this.MemberwiseClone();
        }

        public Prototype DeepClone()
        {
            Prototype prototype = (Prototype) this.MemberwiseClone();
            prototype.Id = prototype.Id;
            prototype.Description = new String(prototype.Description);

            return prototype;
        }
    }
}
