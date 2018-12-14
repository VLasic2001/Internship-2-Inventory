using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Phone : TechnologicalEquipment
    {
        public int PhoneNumber { get; set; }
        public Tuple<string, string> Identity { get; set; }

        public Phone(int serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, string manufacturer, string hasBattery, string phoneNumber, Tuple<string, string> identity)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, manufacturer, hasBattery)
        {
            PhoneNumber = int.Parse(phoneNumber.Replace(" ", ""));
            Identity = identity;
        }
    }
}
