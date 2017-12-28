using System;

public class Class1
{
    public Class1();

    private Sozialversicherung Service;

    
    
        public  CalculateSozialversicherung(Person person)
        {
            var Sozialversicherung = person.Lohn / Math.Pow(person.Rentenversicherung);
            return Sozialversicherung;
        }
    }
        

