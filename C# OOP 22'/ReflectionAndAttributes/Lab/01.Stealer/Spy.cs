namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    { 
        public string StealFieldInfo(string classToInvestigate,params string[] fieldsOfTheClass)
        {
            Type classType = Type.GetType(classToInvestigate);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance
                | BindingFlags.Public| BindingFlags.NonPublic);


            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {classToInvestigate}");

            foreach (FieldInfo field in classFields.Where(a => fieldsOfTheClass.Contains(a.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
