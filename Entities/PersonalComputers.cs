using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class PersonalComputers : Computers
    {
        private string formFactor;
        public PersonalComputers()
        {
            type = "Персональный компьютер";
            CPUNumber = 4;
            MemoryUmount = 8;
            Extensibility = true;
            IsOSOn = false;
            IsPowerOn = false;

            formFactor = "ATX";
        }
    }
}

