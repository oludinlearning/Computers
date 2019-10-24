using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Servers : Computers
    {
        private int units;

        public Servers()
        {
            type = "Сервер";
            CPUNumber = 16;
            MemoryUmount = 32;
            Extensibility = true;
            IsOSOn = false;
            IsPowerOn = false;

            units = 1;
        }
    }
}
