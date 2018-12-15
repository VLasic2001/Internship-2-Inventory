using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Inventory
{
    public class Inventory
    {
        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public double PurchasePrice { get; set; }
        public string Manufacturer { get; set; }

        public Inventory(Guid serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, double purchasePrice, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            PurchasePrice = purchasePrice;
            Manufacturer = manufacturer;
        }
    }
}
