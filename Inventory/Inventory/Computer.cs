using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Computer : TechnologicalEquipment
    {
        public OperatingSystem OperatingSystem { get; set; }
        public bool IsComputerPortable { get; set; }

        public Computer(int serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, string manufacturer, string hasBattery, OperatingSystem operatingSystem, string isComputerPortable)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, manufacturer, hasBattery)
        {
            OperatingSystem = operatingSystem;
            IsComputerPortable = PortabilityCheck(isComputerPortable);
        }

        static bool PortabilityCheck(string isComputerPortable)
        {
            if (isComputerPortable == "yes")
                return true;

            else
                return false;
        }
    }
}
