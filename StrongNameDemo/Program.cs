using StringManipulation;
using static System.Console;

namespace StrongNameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter user name:");
            string userName = ReadLine();
            Clear();
            WriteLine(Greeting.SayHello(userName));
            ReadKey();
        }
    }
}