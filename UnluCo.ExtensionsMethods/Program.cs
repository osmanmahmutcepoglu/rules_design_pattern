using System;

namespace UnluCo.ExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassWordValidator p = new PassWordValidator();
            string pass = "OsmanMahmutcepoglu1";
            bool a = p.IsValid(pass);
            Console.WriteLine(a);
        }
    }
}
