using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Phone : TechnologicalEquipment
    {
        public string PhoneNumber { get; set; }
        public Tuple<string, string> Identity { get; set; }

        public Phone(Guid serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, double purchasePrice, string manufacturer, string hasBattery, string phoneNumber, Tuple<string, string> identity)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer, hasBattery)
        {
            PhoneNumber = phoneNumber.Replace(" ", "");
            Identity = identity;
        }
    }
}
