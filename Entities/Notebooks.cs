using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Notebooks : Computers
    {
        private bool isOpen;
        private bool isBatteryCharging;
        private bool isChargerOn;
        private bool isBatteryInstalled;
        private uint batteryPercentage;

        public bool IsOpen { get { return isOpen; } set { isOpen = value; } }
        public bool IsBatteryCharging { get { return isBatteryCharging; } set { isBatteryCharging = value; } }
        public bool IsChargerOn { get { return isChargerOn; } set { isChargerOn = value; } }
        public bool IsBatteryInstalled { get { return isBatteryInstalled; } set { isBatteryInstalled = value; } }
        public uint BatteryPercentage { get { return batteryPercentage; } set { batteryPercentage = value; } }

        public Notebooks()
        {
            type = "Ноутбук";
            isOpen = false;
            isBatteryCharging = false;
            isChargerOn = false;
            isBatteryInstalled = true;
            batteryPercentage = 100;

            CPUNumber = 2;
            MemoryUmount = 8;
            Extensibility = false;
            IsOSOn = false;
            IsPowerOn = true;
    }
    }
}
