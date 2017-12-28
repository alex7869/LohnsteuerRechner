using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace WindowsService1
{ }



    public class SvService
    {
        public double CalculateSozialversicherung(Person2 person2)
        {
            var rentenversicherung = person2.Lohn * (person2.Rentenversicherung/100);
            return rentenversicherung;
        }
    }
