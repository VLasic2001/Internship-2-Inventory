using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class TechnologicalEquipment : Inventory
    {
        public bool HasBattery { get; set; }

        public TechnologicalEquipment(Guid serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, double purchasePrice, string manufacturer, string hasBattery)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer)
        {
            HasBattery = BatteryCheck(hasBattery);
        }

        static bool BatteryCheck(string hasBattery)
        {
            if (hasBattery == "yes")
                return true;

            else
                return false;
        }
    }
}
