using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{

    class ComputerActions : IComputerActions<Computers>
    {
        public void PowerOff(Computers computer)
        {
            if (computer.IsPowerOn)
            {
                if (computer is Notebooks)
                {
                    Notebooks notebook = (Notebooks)computer;
                    if (!notebook.IsBatteryInstalled && !notebook.IsChargerOn) { notebook.IsPowerOn = false; }
                    else if (notebook.IsBatteryInstalled && notebook.BatteryPercentage < 1) { notebook.IsPowerOn = false; }
                }
                else
                {
                    computer.IsPowerOn = false;
                }
            }
        }

        public void PowerOn(Computers computer)
        {
            if(!computer.IsPowerOn) {
                if (computer is Servers)
                {
                    Servers server = (Servers)computer;
                    {
                        ComputerActions tempAction = new ComputerActions();
                        server.IsPowerOn = true;
                        tempAction.Start(server);
                    }
                }
                else if (computer is Notebooks)
                {                    
                    Notebooks notebook = (Notebooks)computer;
                    if (notebook.IsBatteryInstalled && notebook.BatteryPercentage >= 1)
                    {
                        notebook.IsPowerOn = true;
                    }
                    else if (!notebook.IsBatteryInstalled && notebook.IsChargerOn)
                    {
                        notebook.IsPowerOn = true;
                    }
                }
                else
                {
                    computer.IsPowerOn = true;
                }
            }
        }

        public void PushStartButton(Computers computer)
        {
            ComputerActions tempAction = new ComputerActions();
            if (!computer.IsOSOn && computer.IsPowerOn)
            {
                tempAction.Start(computer);
            }
            else if (computer.IsOSOn)
            {
                tempAction.Shutdown(computer);
            }
        }

        public void Restart(Computers computer)
        {
            if (computer.IsPowerOn && computer.IsOSOn)
            {
                ComputerActions tempAction = new ComputerActions();
                tempAction.Shutdown(computer);
                tempAction.Start(computer);
            }
        }

        public void Shutdown(Computers computer)
        {
            if (computer.IsPowerOn && computer.IsOSOn)
            {
                computer.IsOSOn = false;
            }
        }

        public void Start(Computers computer)
        {
            if (computer.IsPowerOn && !computer.IsOSOn)
            {
                computer.IsOSOn = true;
            }
        }
    }
}