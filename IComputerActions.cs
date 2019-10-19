using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    interface IComputerActions
    {
        void Start(Computers computer);
        void Shutdown(Computers computer);
        void Restart(Computers computer);
        void PowerOn(Computers computer);
        void PowerOff(Computers computer);
        void PushStartButton(Computers computer);
    }
}
