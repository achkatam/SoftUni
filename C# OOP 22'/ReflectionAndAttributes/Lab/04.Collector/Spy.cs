namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Text;
    using System.Xml.Linq;

    public class Spy
    {
        public string CollectGettersAndSetters(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);

            MethodInfo[] classMethods = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            var sb = new StringBuilder();

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();

        }
        public string RevealPrivateMethods(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);

            //Print all private methods 

            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            var sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in privateMethods)
            {
                sb.AppendLine($"{method.Name}");
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            //•	Fields - all fields must be private
            //{ fieldName} must be private!
            //•	Getters all getters are public
            //{ methodName }have to be public!
            //•	Setters - all setters are private
            //{ methodName }have to be private!
            //always start with taking the type of the class
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);


            var sb = new StringBuilder();

            foreach (FieldInfo field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");

            }

            foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().TrimEnd();
        }

        public string StealFieldInfo(string classToInvestigate, params string[] fieldsOfTheClass)
        {
            Type classType = Type.GetType(classToInvestigate);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance
                | BindingFlags.Public | BindingFlags.NonPublic);


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
