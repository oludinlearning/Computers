using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class ComputerActions : IComputerActions
    {
        void IComputerActions.Start(Computers computer)
        {
            if (computer.powerOn) {
                computer.osOn = true;
            }
        }
        void IComputerActions.Shutdown(Computers computer)
        {
            if (computer.powerOn) {
                computer.osOn = false;
            }
        }
        void IComputerActions.Restart(Computers computer)
        {
            IComputerActions tempAction = new ComputerActions();
            if (computer.osOn)
            {
                tempAction.Shutdown(computer);
                tempAction.Start(computer);
            }
        }
        void IComputerActions.PowerOn(Computers computer)
        {
            if (!computer.powerOn)
            {
                computer.powerOn = true;
            }
        }
        void IComputerActions.PowerOff(Computers computer)
        {
            if (computer.powerOn)
            {
                computer.powerOn = false;
            }
        }
        void IComputerActions.PushStartButton(Computers computer)
        {
            IComputerActions tempAction = new ComputerActions();
            if (!computer.powerOn)
            {
                tempAction.Start(computer);
            }
            else
            {
                tempAction.Shutdown(computer);
            }
        }
    }
}