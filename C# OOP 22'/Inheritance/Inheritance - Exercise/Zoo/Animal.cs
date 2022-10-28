namespace Zoo
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
    }
}
