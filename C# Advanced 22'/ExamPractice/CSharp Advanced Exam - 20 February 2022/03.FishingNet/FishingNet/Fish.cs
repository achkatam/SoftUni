namespace FishingNet
{
    public class Fish
    {
        //•	FishType: string
        //•	Length: double
        //•	Weight: double
        //The class constructor should receive fish type, length, and weight.
        //The class should also have a method:
        //•	Override the ToString() method in the format: "There is a {fishType}, {length} cm. long, and {weight} gr. in weight."

        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }

        public override string ToString() => $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
    }
}
