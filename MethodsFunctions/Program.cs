using System;

namespace MethodsFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from method");
            Console.Read();
        }
        // access modifier (static) return type methode name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            
        }
    }
}
