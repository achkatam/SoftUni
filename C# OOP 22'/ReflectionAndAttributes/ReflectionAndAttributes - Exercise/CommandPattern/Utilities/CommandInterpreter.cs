namespace CommandPattern.Utilities
{
    using System;
    using System.Linq;
    using System.Reflection;
    using CommandPattern.Utilities.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split(' ');
            string cmd = tokens[0];

            string[] cmdArgs = tokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetEntryAssembly();

            Type cmdType = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{cmd}Command");

            if (cmdType == null)
            {
                throw new InvalidOperationException("Invalid command type!");
            }

            MethodInfo execute = cmdType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(m => m.Name == "Execute");

            if (execute == null)
            {
                throw new InvalidOperationException("Invalid method!");
            }

            object cmdInstance = Activator.CreateInstance(cmdType);

            string result = (string)execute.Invoke(cmdInstance, new object[] { cmdArgs });

            return result;
        }
    }
}
