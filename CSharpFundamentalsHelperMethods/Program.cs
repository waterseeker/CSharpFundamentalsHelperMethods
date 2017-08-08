using System;

namespace CSharpFundamentalsHelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("sunshine");
            string myOverloadedValue = superSecretFormula("you", "Monday");
            Console.WriteLine(myValue);
            Console.WriteLine(myOverloadedValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            //some cool stuff here
            return "Hello World!";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }

        private static string superSecretFormula(string name, string day)
        {
            return String.Format("Hello, {0}! Happy {1}.", name, day);
        }

    }
}