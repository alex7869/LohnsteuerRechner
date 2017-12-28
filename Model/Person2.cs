using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person2
    {
        public Person2 (double lohn, string name, double rentenversicherung, double pflegeversicherung, double arbeitslosenversicherung, double krankenversicherung)
        {
            Lohn = lohn;
            Name = name;
            Rentenversicherung = rentenversicherung;
            Pflegeversicherung = pflegeversicherung;
            Arbeitslosenversicherung = arbeitslosenversicherung;
            Krankenversicherung = krankenversicherung;
        }

        public double Lohn { get; }

        public string Name { get; }

        public double Rentenversicherung { get; }

        public double Pflegeversicherung { get; }

        public double Arbeitslosenversicherung { get; }

        public double Krankenversicherung { get; }
    }
}
