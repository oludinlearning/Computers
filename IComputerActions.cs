using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    interface IComputerActions<T>
    {
        void Start(T computer);
        void Shutdown(T computer);
        void Restart(T computer);
        void PowerOn(T computer);
        void PowerOff(T computer);
        void PushStartButton(T computer);
    }
}
