using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class TechnologicalEquipment : Inventory
    {
        public bool HasBattery { get; set; }

        public TechnologicalEquipment(int serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, string manufacturer, string hasBattery)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, manufacturer)
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
