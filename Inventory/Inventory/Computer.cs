using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Computer : TechnologicalEquipment
    {
        public OperatingSystems OperatingSystem { get; set; }
        public bool IsComputerPortable { get; set; }

        public Computer(Guid serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, double purchasePrice, Manufacturers manufacturer, string hasBattery, OperatingSystems operatingSystem, string isComputerPortable)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer, hasBattery)
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
