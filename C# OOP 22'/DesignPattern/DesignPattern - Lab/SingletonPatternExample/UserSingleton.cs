namespace SingletonPatternExample
{
    using DeviceId;
    using DeviceId.Formatters;
    using System;

    public class UserSingleton
    {
        private static UserSingleton instance;
        private UserSingleton()
        {
            Console.WriteLine("Initializing..");
            DeviceID = new DeviceIdBuilder()
                .AddMachineName()
                .AddOsVersion()
                .ToString();
        }

        public static UserSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSingleton();
                }

                return instance;
            }
        }

        public string DeviceID { get; }
    }
}
