using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class NotebookActions : IComputerActions<Notebooks>
    {
        void IComputerActions<Notebooks>.Start(Notebooks computer)
        {
            if (computer.powerOn && computer.isOpen)
            {
                computer.osOn = true;
            }
        }
        void IComputerActions<Notebooks>.Shutdown(Notebooks computer)
        {
            if (computer.powerOn)
            {
                computer.osOn = false;
            }
        }
        void IComputerActions<Notebooks>.Restart(Notebooks computer)
        {
            IComputerActions<Notebooks> tempAction = new NotebookActions();
            if (computer.osOn)
            {
                tempAction.Shutdown(computer);
                tempAction.Start(computer);
            }
        }
        void IComputerActions<Notebooks>.PowerOn(Notebooks computer)
        {
            if (!computer.powerOn)
            {
                computer.powerOn = true;
            }
        }
        void IComputerActions<Notebooks>.PowerOff(Notebooks computer)
        {
            if (computer.powerOn)
            {
                computer.powerOn = false;
            }
        }
        void IComputerActions<Notebooks>.PushStartButton(Notebooks computer)
        {
            IComputerActions<Notebooks> tempAction = new NotebookActions();
            if (!computer.osOn && computer.isOpen)
            {
                tempAction.Start(computer);
            }            
        }

        void Open(Notebooks computer) {
            computer.isOpen = true;
        }

        void Close(Notebooks computer)
        {
            computer.isOpen = false;
        }
    }
}
