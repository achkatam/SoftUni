namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(125, 211);

            //20 * 10
            sportCar.Drive(20);

            System.Console.WriteLine(sportCar.Fuel);

            CrossMotorcycle cross = new CrossMotorcycle(75, 40);

            cross.Drive(10);

            System.Console.WriteLine(cross.Fuel);
        }
    }
}
