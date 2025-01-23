using System.Diagnostics.Metrics;
using System.Reflection;

namespace Mehodschallenge
{
    internal class Program
    {
        static int ClacWhiteSpaces(string value)
        {
            int counter = 0;
            for (int i = 0; i < value.Length; i++)
            {
                
                if(value[i] == ' ')
                {
                    counter++;
                   
                }
              
            }
            return counter;  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter statement");
           string statment=Console.ReadLine();
            Console.WriteLine(ClacWhiteSpaces(statment));
        }
    }
}
