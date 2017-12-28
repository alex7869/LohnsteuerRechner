using System;

public class Class1
{
    public Class1()

        namespace ConsoleApp
}




 class Program
    

    static void Main(string[] args)
        {
            var SozialversicherungService = new SozialversicherungService();

            var person = new Person(1800, "Alex", 14, 1,7, 8, 9);

            var Sozialversicherung = SozialversicherungService.CalculateSozialvericherung(person);

            Console.WriteLine(Sozialvericherung);
        }

