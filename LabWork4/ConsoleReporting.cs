using System.Reflection;

namespace LabWork4
{
    internal class ConsoleReporting
    {
        public static void Parse(List<object> objects)
        {
            string outString = string.Empty;
            objects.ForEach(obj =>
            {
                bool IsHorizontal = false;

                Type ObjType = obj.GetType();

                object[] attributes = ObjType.GetCustomAttributes(false);
                foreach (Attribute attribute in attributes)
                {
                    if (attribute is HorizontalAlignmentAttribute) IsHorizontal = true;
                }

                outString += $"{new string('=', 13)} {ObjType} {new string('=', 13)} \n";

                foreach (var property in ObjType.GetProperties(BindingFlags.Instance
                    | BindingFlags.Public
                    | BindingFlags.NonPublic))
                {
                    bool IsPrintable = true;

                    object[] PropAttrs = property.GetCustomAttributes(false);
                    foreach (Attribute attr in PropAttrs)
                    {
                        if (attr is NotPrintableAttribute) IsPrintable = false;
                    }

                    if (IsPrintable)
                    {
                        if (IsHorizontal) outString += $"{property.Name}: {property.GetValue(obj)} | ";
                        else outString += $"{property.Name}: \t {property.GetValue(obj)} \n";
                    }
                }
                outString += $"\n{new string('=', 33)}\n\n";
            });
            Console.WriteLine(outString);
        }
    }
}
