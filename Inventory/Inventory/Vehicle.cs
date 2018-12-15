using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Vehicle : Inventory
    {
        public DateTime LicencePlateExpiryDate { get; set; }
        public double KilometeresDriven { get; set; }

        public Vehicle(Guid serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, double purchasePrice, string manufacturer, DateTime licencePlateExpiryDate, double kilometeresDriven)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer)
        {
            LicencePlateExpiryDate = licencePlateExpiryDate;
            KilometeresDriven = kilometeresDriven;
        }
    }
}
