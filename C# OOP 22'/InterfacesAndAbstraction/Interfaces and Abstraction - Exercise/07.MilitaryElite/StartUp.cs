namespace MilitaryElite
{
    using MilitaryElite.Core;
    using MilitaryElite.Core.Contracts;
    using MilitaryElite.IO;
    using MilitaryElite.IO.Contracts;
    using MilitaryElite.Models;
    using System.Numerics;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            IEngine engine = new Engine(reader, writer);
            engine.Run();

            //Engineer 107 Peter Johnson 107.107 Airforces Plane 17
            //Commando 222 John Miller 2900.29 Airforces BeatAliens Finished
            //Engineer 999 Al Bundy 222.22 Marins ItsWrong 200
            //End

            //output
            //Name: Peter Johnson Id: 107 Salary: 107.11
            //Corps: Airforces
            //Repairs:
            //  Part Name: Plane Hours Worked: 17
            //Name: John Miller Id: 222 Salary: 2900.29
            //Corps: Airforces
            //Missions:
            //  Code Name: BeatAliens State: Finished
        }
    }
}
