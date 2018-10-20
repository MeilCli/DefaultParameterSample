using System;

namespace DefaultParameterSample.Core
{
    public class Sample
    {
        public const string ConstString = "const_string: 1";
        public static readonly string ReadonlyString = ConstString;

        public void Method(string value = ConstString)
        {
            Console.WriteLine(value);
        }
    }
}
