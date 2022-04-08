using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking fo prime number");
            Console.Write("Enter prime number:");
            int primeNumber = int.Parse(Console.ReadLine());
            if(primeNumber == 17){
                Console.WriteLine("Prime number");
            }
            if(primeNumber == 57){
                Console.WriteLine("not prime number");
            }
            else{
                Console.WriteLine("invalid input");

            }

      
         
        }
    }
}
