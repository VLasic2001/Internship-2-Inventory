using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Inventory
{
    public class Inventory
    {
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public string Manufacturer { get; set; }

        public Inventory(int serialNumber, string description, DateTime dateOfPurchase, int monthsOfWarranty, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            Manufacturer = manufacturer;
        }
    }
}
