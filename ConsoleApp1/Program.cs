using System;
using Model;
using WindowsService2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                {
                    
                    {
                        var svserivce  = new SvService();

                        var person = new Person2(2000, "Alex", 14, 1.7, 8, 9);

                        var sv = svserivce.CalculateSvService(person);

                        Console.WriteLine(sv);
                    }
                }
            }
}
    }
}
