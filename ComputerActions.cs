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
            if (computer.isPowerOn)
            {
                if (computer is Notebooks)
                {
                    Notebooks notebook = (Notebooks)computer;
                    if (!notebook.isBatteryInstalled && !notebook.isChargerOn) { notebook.isPowerOn = false; }
                    else if (notebook.isBatteryInstalled && notebook.batteryPercentage < 1) { notebook.isPowerOn = false; }
                }
                else
                {
                    computer.isPowerOn = false;
                }
            }
        }

        public void PowerOn(Computers computer)
        {
            if(!computer.isPowerOn) {
                if (computer is Servers)
                {
                    Servers server = (Servers)computer;
                    {
                        ComputerActions tempAction = new ComputerActions();
                        server.isPowerOn = true;
                        tempAction.Start(server);
                    }
                }
                else if (computer is Notebooks)
                {                    
                    Notebooks notebook = (Notebooks)computer;
                    if (notebook.isBatteryInstalled && notebook.batteryPercentage >= 1)
                    {
                        notebook.isPowerOn = true;
                    }
                    else if (!notebook.isBatteryInstalled && notebook.isChargerOn)
                    {
                        notebook.isPowerOn = true;
                    }
                }
                else
                {
                    computer.isPowerOn = true;
                }
            }
        }

        public void PushStartButton(Computers computer)
        {
            ComputerActions tempAction = new ComputerActions();
            if (!computer.isOSOn && computer.isPowerOn)
            {
                tempAction.Start(computer);
            }
            else if (computer.isOSOn)
            {
                tempAction.Shutdown(computer);
            }
        }

        public void Restart(Computers computer)
        {
            if (computer.isPowerOn && computer.isOSOn)
            {
                ComputerActions tempAction = new ComputerActions();
                tempAction.Shutdown(computer);
                tempAction.Start(computer);
            }
        }

        public void Shutdown(Computers computer)
        {
            if (computer.isPowerOn && computer.isOSOn)
            {
                computer.isOSOn = false;
            }
        }

        public void Start(Computers computer)
        {
            if (computer.isPowerOn && !computer.isOSOn)
            {
                computer.isOSOn = true;
            }
        }
    }
}