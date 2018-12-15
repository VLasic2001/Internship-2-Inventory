using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            var choice = "";

            var vehicleList = new List<Vehicle>();
            var phoneList = new List<Phone>();
            var computerList = new List<Computer>();
            var myPhone = new Phone(Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), "a", new DateTime(1000, 07, 01), 6, 1000, "a","yes", "753489", new Tuple<string, string>("a", "a"));
            phoneList.Add(myPhone);
            do
            {
                Options();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    {
                        var item = Console.ReadLine();
                        switch (item)
                        {
                            case "computer":
                            {
                                computerList = AddComputer(computerList);
                                break;
                            }

                            case "phone":
                            {
                                phoneList = AddPhone(phoneList);
                                break;
                            }

                            case "vehicle":
                            {
                                vehicleList = AddVehicle(vehicleList);
                                break;
                            }
                        }

                        break;
                    }

                    case "2":
                    {
                        var item = Console.ReadLine();
                        switch (item)
                        {
                            case "computer":
                            {
                                computerList = DeleteComputer(computerList);
                                break;
                            }

                            case "phone":
                            {
                                phoneList = DeletePhone(phoneList);
                                break;
                            }

                            case "vehicle":
                            {
                                vehicleList = DeleteVehicle(vehicleList);
                                break;
                            }
                        }

                        break;
                    }

                    case "3":
                    {
                        var item = Console.ReadLine();
                        switch (item)
                        {
                            case "computer":
                            {
                                PrintComputerDetails(computerList);
                                break;
                            }

                            case "phone":
                            {
                                PrintPhoneDetails(phoneList);
                                break;
                            }

                            case "vehicle":
                            {

                                PrintVehicleDetails(vehicleList);
                                break;
                            }
                        }

                        break;
                    }

                    case "4":
                    {
                        PrintComputersWithCorrectExpirationYear(computerList);
                        break;
                    }

                    case "5":
                    {
                        BatteryAmount(phoneList, computerList);
                        break;
                    }

                    case "6":
                    {
                        var item = Console.ReadLine();
                        switch (item)
                        {
                            case "computer":
                            {
                                ComputerOperatingSystemCheck(computerList);
                                break;
                            }

                            case "phone":
                            {
                                PhoneManufacturerCheck(phoneList);
                                break;
                            }
                        }

                        break;
                    }

                    case "7":
                    {
                        PrintAllPhonesWithCorrectExpirationYear(phoneList);
                        break;
                    }
                }


            } while (choice != "Exit");
        }

        static void Options()
        {
            Console.WriteLine("Press the number of the action you want to take.");
            Console.WriteLine("1. Add an item to inventory.");
            Console.WriteLine("2. Delete an item from inventory.");
            Console.WriteLine("3. Print all details of an inventory piece");
            Console.WriteLine("4. Print all computers whose warranty expires in selected year");
            Console.WriteLine("5. Print how many pieces of technological equpipment have a battery");
            Console.WriteLine("6. Print all phones of a specific brand or all computers with a specific operating system");
            Console.WriteLine("7. Print all phones whose warranty expires in selected year");
            Console.WriteLine("Exit - stop the program");
        }

        static List<Computer> AddComputer(List<Computer> computerList)
        {
            Console.WriteLine("Enter serial number");
            var serialNumber = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Enter description");
            var description = Console.ReadLine();
            Console.WriteLine("Enter year of purchase");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of purchase");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of purchase");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);
            Console.WriteLine("Enter number of months of warranty");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price at time of purchase");
            var purchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacturer name");
            var manufacturer = Console.ReadLine();
            Console.WriteLine("Enter 'yes' if phone has a battery");
            var hasBattery = Console.ReadLine();
            Console.WriteLine($"press {(int) OperatingSystems.Windows} to select Windows as operating system");
            Console.WriteLine($"press {(int) OperatingSystems.macOS} to select macOS as operating system");
            Console.WriteLine($"press {(int) OperatingSystems.Linux} to select Linux as operating system");
            var operatingSystem = int.Parse(Console.ReadLine());
            var operatingSystemAsOperatingSystems = (OperatingSystems) operatingSystem;
            Console.WriteLine("Enter 'yes' if computer is portable");
            var isComputerPortable = Console.ReadLine();
            var newComputer = new Computer(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice,
                manufacturer, hasBattery, operatingSystemAsOperatingSystems, isComputerPortable);
            computerList.Add(newComputer);
            return computerList;
        }

        static List<Phone> AddPhone(List<Phone> phoneList)
        {
            Console.WriteLine("Enter serial number");
            var serialNumber = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Enter description");
            var description = Console.ReadLine();
            Console.WriteLine("Enter year of purchase");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of purchase");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of purchase");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);
            Console.WriteLine("Enter number of months of warranty");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price at time of purchase");
            var purchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacturer name");
            var manufacturer = Console.ReadLine();
            Console.WriteLine("Enter 'yes' if phone has a battery");
            var hasBattery = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            var phoneNumber = Console.ReadLine();
            phoneNumber = phoneNumber.Replace(" ", "");
            Console.WriteLine("Enter first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            var lastName = Console.ReadLine();
            var identity = new Tuple<string, string>(firstName, lastName);
            var newPhone = new Phone(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice,
                manufacturer, hasBattery, phoneNumber, identity);
            phoneList.Add(newPhone);
            return phoneList;
        }

        static List<Vehicle> AddVehicle(List<Vehicle> vehicleList)
        {
            Console.WriteLine("Enter serial number");
            var serialNumber = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Enter description");
            var description = Console.ReadLine();
            Console.WriteLine("Enter year of purchase");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of purchase");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of purchase");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);
            Console.WriteLine("Enter number of months of warranty");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price at time of purchase");
            var purchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacturer name");
            var manufacturer = Console.ReadLine();
            Console.WriteLine("Enter year of licence plate expiration");
            var yearOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of licence plate expiration");
            var monthOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of licence plate expiration");
            var dayOfExpiration = int.Parse(Console.ReadLine());
            var licencePlateExpiryDate = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);
            Console.WriteLine("Enter kilometers driven");
            var kilometersDriven = double.Parse(Console.ReadLine());
            var newComputer = new Vehicle(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice,
                manufacturer, licencePlateExpiryDate, kilometersDriven);
            vehicleList.Add(newComputer);
            return vehicleList;
        }

        static List<Computer> DeleteComputer(List<Computer> computerList)
        {
            Console.WriteLine("Enter serial number of computer you want to delete from inventory");
            foreach (var Computer in computerList)
            {
                if (Computer.SerialNumber == Guid.Parse(Console.ReadLine()))
                    computerList.Remove(Computer);
            }

            return computerList;
        }

        static List<Phone> DeletePhone(List<Phone> phoneList)
        {
            Console.WriteLine("Enter serial number of phone you want to delete from inventory");
            foreach (var Phone in phoneList)
            {
                if (Phone.SerialNumber == Guid.Parse(Console.ReadLine()))
                    phoneList.Remove(Phone);
            }

            return phoneList;
        }

        static List<Vehicle> DeleteVehicle(List<Vehicle> vehicleList)
        {
            Console.WriteLine("Enter serial number of vehicle you want to delete from inventory");
            foreach (var Vehicle in vehicleList)
            {
                if (Vehicle.SerialNumber == Guid.Parse(Console.ReadLine()))
                    vehicleList.Remove(Vehicle);
            }

            return vehicleList;
        }

        static void PrintComputerDetails(List<Computer> computerList)
        {
            Console.WriteLine("Enter serial number of computer you want to print the details of");
            foreach (var Computer in computerList)
            {
                if (Computer.SerialNumber == Guid.Parse(Console.ReadLine()))
                {
                    Console.WriteLine($"The description of this computer is '{Computer.Description}'");
                    Console.WriteLine($"The date of purchase of this computer is {Computer.DateOfPurchase}");
                    Console.WriteLine(
                        $"The months of warranty remaining of this computer is {Computer.MonthsOfWarranty}");
                    Console.WriteLine($"The price at purchase of this computer is {Computer.PurchasePrice}");
                    Console.WriteLine($"The manufacturer of this computer is {Computer.Manufacturer}");
                    if (Computer.HasBattery)
                        Console.WriteLine("This computer has a battery");
                    else
                        Console.WriteLine("This computer does not have a battery");
                    Console.WriteLine($"This computer's operating system is {Computer.OperatingSystem}");
                    if (Computer.IsComputerPortable)
                        Console.WriteLine("This computer is portable");
                    else
                        Console.WriteLine("This computer is not portable");
                }
            }
        }

        static void PrintPhoneDetails(List<Phone> phoneList)
        {
            Console.WriteLine("Enter serial number of phone you want to print the details of");
            foreach (var Phone in phoneList)
            {
                if (Phone.SerialNumber == Guid.Parse(Console.ReadLine()))
                {
                    Console.WriteLine($"The description of this phone is '{Phone.Description}'");
                    Console.WriteLine($"The date of purchase of this phone is {Phone.DateOfPurchase}");
                    Console.WriteLine($"The months of warranty remaining of this phone is {Phone.MonthsOfWarranty}");
                    Console.WriteLine($"The price at purchase of this phone is {Phone.PurchasePrice}");
                    Console.WriteLine($"The manufacturer of this phone is {Phone.Manufacturer}");
                    if (Phone.HasBattery)
                        Console.WriteLine("This phone has a battery");
                    else
                        Console.WriteLine("This phone does not have a battery");
                    Console.WriteLine($"The number of this phone is {Phone.PhoneNumber}");
                    Console.WriteLine($"The owner of this phone is {Phone.Identity.Item1} {Phone.Identity.Item2}");
                }
            }
        }

        static void PrintVehicleDetails(List<Vehicle> vehicleList)
        {
            Console.WriteLine("Enter serial number of vehicle you want to print the details of");
            foreach (var Vehicle in vehicleList)
            {
                if (Vehicle.SerialNumber == Guid.Parse(Console.ReadLine()))
                {
                    Console.WriteLine($"The description of this vehicle is '{Vehicle.Description}'");
                    Console.WriteLine($"The date of purchase of this vehicle is {Vehicle.DateOfPurchase}");
                    Console.WriteLine($"The months of warranty remaining of this vehicle is {Vehicle.MonthsOfWarranty}");
                    Console.WriteLine($"The price at purchase of this vehicle is {Vehicle.PurchasePrice}");
                    Console.WriteLine($"The manufacturer of this vehicle is {Vehicle.Manufacturer}");
                    Console.WriteLine($"The date of licence plate expiry of this vehicle is {Vehicle.LicencePlateExpiryDate}");
                    Console.WriteLine($"The amount of kilometers driven in this vehicle is {Vehicle.KilometersDriven}");
                }
            }
        }

        static void PrintComputersWithCorrectExpirationYear(List<Computer> computerList)
        {
            Console.WriteLine("Enter expiration year");
            var ExpiratonYear = int.Parse(Console.ReadLine());
            foreach (var Computer in computerList)
            {
                if ((Computer.DateOfPurchase.Year + ((Computer.DateOfPurchase.Month + Computer.MonthsOfWarranty) / 12)) ==
                    ExpiratonYear)
                {
                    Console.WriteLine($"Computer with the serial number {Computer.SerialNumber}'s warranty expires that year");
                }
            }
        }

        static void BatteryAmount(List<Phone> phoneList, List<Computer> computerList)
        {
            var numberOfBatteries = 0;
            foreach (var Phone in phoneList)
            {
                if (Phone.HasBattery)
                    numberOfBatteries += 1;
            }
            foreach (var Computer in computerList)
            {
                if (Computer.HasBattery)
                    numberOfBatteries += 1;
            }

            Console.WriteLine($"{numberOfBatteries} pieces of technological equipment have a battery");
        }

        static void ComputerOperatingSystemCheck(List<Computer> computerList)
        {
            Console.WriteLine("Enter the operating system");
            var operatingSystem = (OperatingSystems) int.Parse(Console.ReadLine());
            foreach (var Computer in computerList)
            {
                if(Computer.OperatingSystem == operatingSystem);
                    Console.WriteLine($"Computer with the serial number {Computer.SerialNumber} has the selected operating system");
            }
        }

        static void PhoneManufacturerCheck(List<Phone> phoneList)
        {
            Console.WriteLine("Enter the brand");
            var brand = Console.ReadLine();
            brand = brand.ToLower();
            foreach (var Computer in phoneList)
            {
                var manufacturer = Computer.Manufacturer;
                if (manufacturer.ToLower() == brand)
                {
                    Console.WriteLine($"Phone with the serial number {Computer.SerialNumber} is made by the selected manufacturer");
                }
            }
        }

        static void PrintAllPhonesWithCorrectExpirationYear(List<Phone> phoneList)
        {
            Console.WriteLine("Enter expiration year");
            var expiratonYear = int.Parse(Console.ReadLine());
            foreach (var Phone in phoneList)
            {
                if ((Phone.DateOfPurchase.Year + ((Phone.DateOfPurchase.Month + Phone.MonthsOfWarranty) / 12)) ==
                    expiratonYear)
                {
                    Console.WriteLine($"{Phone.Identity.Item1} {Phone.Identity.Item2}'s phone with the number {Phone.PhoneNumber} warranty expires in the selected year");
                    var currentValue = CurrentValueCalculator(Phone.PurchasePrice, Phone.DateOfPurchase, expiratonYear);
                    Console.WriteLine($"The phone was purchased at the price {Phone.PurchasePrice} and it's current value is {currentValue} the price lowered by {Phone.PurchasePrice-currentValue}");
                }
            }
        }

        static double CurrentValueCalculator(double purchasePrice, DateTime purchaseDateTime, int expirationYear)
        {
            if ((expirationYear * 12) - ((purchaseDateTime.Year*12)+purchaseDateTime.Month) >= 12)
            {
                return (purchasePrice * 0.3);
            }
            else if (((((purchaseDateTime.Year * 12) + purchaseDateTime.Month) - (expirationYear * 12)) * 0.05) >= 0.3)
            {
                return (purchasePrice * 0.3);
            }
            else if ((((expirationYear * 12) - ((purchaseDateTime.Year * 12) + purchaseDateTime.Month))*0.05) >= 0.3)
            {
                return (purchasePrice * 0.3);
            }
            else
            {
                if ((((purchaseDateTime.Year * 12) + purchaseDateTime.Month) - (expirationYear * 12)) > 0)
                {
                    return purchasePrice -
                           (((((purchaseDateTime.Year * 12) + purchaseDateTime.Month) - (expirationYear * 12))) * 0.05 *
                            purchasePrice);
                }
                else
                {
                    return purchasePrice -
                           ((((expirationYear * 12)-((purchaseDateTime.Year * 12) + purchaseDateTime.Month))) * 0.05 *
                            purchasePrice);
                }
            }
        }
    }
}
