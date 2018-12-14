using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Vehicle : Inventory
    {
        public DateTime LicencePlateExpiryDate { get; set; }
        public double KilometeresDriven { get; set; }

        public Vehicle(int serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, string manufacturer, DateTime licencePlateExpiryDate, double kilometeresDriven)
            :base(serialNumber, description, dateOfPurchase, monthsOfWarranty, manufacturer)
        {
            LicencePlateExpiryDate = licencePlateExpiryDate;
            KilometeresDriven = kilometeresDriven;
        }
    }
}
