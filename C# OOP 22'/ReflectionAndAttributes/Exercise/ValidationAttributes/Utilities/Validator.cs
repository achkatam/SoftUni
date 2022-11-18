namespace ValidationAttributes.Utilities
{
    using System;
    using System.Linq;
    using System.Reflection;
    using ValidationAttributes.Utilities.Attributes;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();

            PropertyInfo[] propsInfo = objType.GetProperties()
                .Where(p => p.CustomAttributes.Any(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.AttributeType)))
                .ToArray();

            foreach (PropertyInfo validProp in propsInfo)
            {
                //CustomAttributeData[] customAttrs = validProp.CustomAttributes
                //    .ToArray();
                object[] customAttributes = validProp.GetCustomAttributes()
                    .Where(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.GetType()))
                    .ToArray();

                object propValue = validProp.GetValue(obj);

                foreach (object customAttr in customAttributes)
                {

                    MethodInfo isValidMethod = customAttr.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public)
                        .FirstOrDefault(mi => mi.Name == "IsValid");

                    if (isValidMethod == null)
                    {
                        throw new InvalidOperationException("Your custom attribute doesn't have IsValid method!");
                    }


                    bool result = (bool)isValidMethod.Invoke(customAttr, new object[] { propValue });

                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
