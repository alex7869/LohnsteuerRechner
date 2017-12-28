using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    static class Program
    {

        public class SVService
        {
            public double CalculateBmi(Person person)
            {
                var bmi = person.Weight / Math.Pow(person.Height, 2);
                return bmi;
            }
        }

    }
    }
}
