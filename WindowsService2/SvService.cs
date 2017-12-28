using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService2
{

    public class SvService

    {
        public double CalculateSvService(Person2 person)
        {
            var sv = person.Lohn * (person.Rentenversicherung / 100);
            return sv;
        }

    }
}



    


   
    
    
