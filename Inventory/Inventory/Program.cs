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

            var vehicleList = VehicleAdd();
            var phoneList = PhoneAdd();
            var computerList = ComputerAdd();
            
            do
            {
                Options();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    {
                        Console.WriteLine("1. Computer");
                        Console.WriteLine("2. Phone");
                        Console.WriteLine("3. Vehicle");
                        var item = int.Parse(Console.ReadLine());
                            switch (item)
                        {

                            case 1:
                            {
                                computerList = AddComputer(computerList);
                                break;
                            }

                            case 2:
                            {
                                phoneList = AddPhone(phoneList);
                                break;
                            }

                            case 3:
                            {
                                vehicleList = AddVehicle(vehicleList);
                                break;
                            }
                        }

                        break;
                    }

                    case "2":
                    {
                        Console.WriteLine("1. Computer");
                        Console.WriteLine("2. Phone");
                        Console.WriteLine("3. Vehicle");
                        var item = int.Parse(Console.ReadLine());
                        switch (item)
                        {
                            case 1:
                            {
                                computerList = DeleteComputer(computerList);
                                break;
                            }

                            case 2:
                            {
                                phoneList = DeletePhone(phoneList);
                                break;
                            }

                            case 3:
                            {
                                vehicleList = DeleteVehicle(vehicleList);
                                break;
                            }
                        }

                        break;
                    }

                    case "3":
                    {
                        Console.WriteLine("1. Computer");
                        Console.WriteLine("2. Phone");
                        Console.WriteLine("3. Vehicle");
                        var item = int.Parse(Console.ReadLine());
                        switch (item)
                        {
                            case 1:
                            {
                                PrintComputerDetails(computerList);
                                break;
                            }

                            case 2:
                            {
                                PrintPhoneDetails(phoneList);
                                break;
                            }

                            case 3:
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
                        Console.WriteLine("1. Computer operating system");
                        Console.WriteLine("2. Phone brand");
                        var item = int.Parse(Console.ReadLine());
                        switch (item)
                        {
                            case 1:
                            {
                                ComputerOperatingSystemCheck(computerList);
                                break;
                            }

                            case 2:
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

                    case "8":
                    {
                        PrintAllVehiclesWithExpiryInNextMonth(vehicleList);
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
            Console.WriteLine("8. Print all vehicles whose warranty expires in the following month");
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
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Computer in computerList.ToArray())
            {
                if (Computer.SerialNumber == serialNumber)
                {
                    var id = computerList.IndexOf(Computer);
                    computerList.RemoveAt(id);
                }
            }

            return computerList;
        }

        static List<Phone> DeletePhone(List<Phone> phoneList)
        {
            Console.WriteLine("Enter serial number of phone you want to delete from inventory");
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Phone in phoneList.ToArray())
            {
                if (Phone.SerialNumber == serialNumber)
                {
                    var id = phoneList.IndexOf(Phone);
                    phoneList.RemoveAt(id);
                }
            }

            return phoneList;
        }

        static List<Vehicle> DeleteVehicle(List<Vehicle> vehicleList)
        {
            Console.WriteLine("Enter serial number of vehicle you want to delete from inventory");
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Vehicle in vehicleList.ToArray())
            {
                if (Vehicle.SerialNumber == serialNumber)
                {
                    var id = vehicleList.IndexOf(Vehicle);
                    vehicleList.Remove(Vehicle);
                }
            }

            return vehicleList;
        }

        static void PrintComputerDetails(List<Computer> computerList)
        {
            Console.WriteLine("Enter serial number of computer you want to print the details of");
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Computer in computerList)
            {
                if (Computer.SerialNumber == serialNumber)
                {
                    Console.WriteLine($"The description of this computer is '{Computer.Description}'");
                    Console.WriteLine($"The date of purchase of this computer is {Computer.DateOfPurchase.ToShortDateString()}");
                    Console.WriteLine(
                        $"The months of warranty of this computer is {Computer.MonthsOfWarranty}");
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
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Phone in phoneList)
            {
                if (Phone.SerialNumber == serialNumber)
                {
                    Console.WriteLine($"The description of this phone is '{Phone.Description}'");
                    Console.WriteLine($"The date of purchase of this phone is {Phone.DateOfPurchase.ToShortDateString()}");
                    Console.WriteLine($"The months of warranty of this phone is {Phone.MonthsOfWarranty}");
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
            var serialNumber = Guid.Parse(Console.ReadLine());
            foreach (var Vehicle in vehicleList)
            {
                if (Vehicle.SerialNumber == serialNumber)
                {
                    Console.WriteLine($"The description of this vehicle is '{Vehicle.Description}'");
                    Console.WriteLine($"The date of purchase of this vehicle is {Vehicle.DateOfPurchase.ToShortDateString()}");
                    Console.WriteLine($"The months of warranty of this vehicle is {Vehicle.MonthsOfWarranty}");
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
            Console.WriteLine("Select the operating system");
            Console.WriteLine($"press {(int)OperatingSystems.Windows} to select Windows as operating system");
            Console.WriteLine($"press {(int)OperatingSystems.macOS} to select macOS as operating system");
            Console.WriteLine($"press {(int)OperatingSystems.Linux} to select Linux as operating system");
            var operatingSystem = (OperatingSystems) int.Parse(Console.ReadLine());
            foreach (var Computer in computerList)
            {
                if(Computer.OperatingSystem == operatingSystem)
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
                    Console.WriteLine($"The phone was purchased at the price {Phone.PurchasePrice} and it's current value is {currentValue}, the price lowered by {Phone.PurchasePrice-currentValue}");
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

        static void PrintAllVehiclesWithExpiryInNextMonth(List<Vehicle> vehicleList)
        {
            foreach (var Vehicle in vehicleList)
            {
                var timeDiff = Vehicle.LicencePlateExpiryDate - DateTime.Now;
                var kilometersDriven = Vehicle.KilometersDriven;
                var currentValue = Vehicle.PurchasePrice;
                if (timeDiff.TotalDays <= 30)
                {
                    Console.WriteLine($"Vehicle with the serial number {Vehicle.SerialNumber}'s warranty expires in the next month");
                    while (kilometersDriven >= 20000 && currentValue >= (Vehicle.PurchasePrice * 0.3))
                    {
                        currentValue = currentValue - Vehicle.PurchasePrice * 0.1;
                        kilometersDriven -= 20000;
                    }

                    Console.WriteLine($"The vehicle was purchased at the price {Vehicle.PurchasePrice} and it's current value is {currentValue}, the price lowered by {Vehicle.PurchasePrice-currentValue}");
                    Console.WriteLine();
                }
            }
        }

        static List<Vehicle> VehicleAdd()
        {
            var vehicle1 = new Vehicle(Guid.NewGuid(), "Black", new DateTime(2016, 07, 16), 12, 203362.5, "Audi", new DateTime(2020, 07, 01), 10000);
            var vehicle2 = new Vehicle(Guid.NewGuid(), "Blue", new DateTime(2018, 03, 25), 18, 160527, "Volvo", new DateTime(2022, 03, 25), 100000);
            var vehicle3 = new Vehicle(Guid.NewGuid(), "Gray", new DateTime(2018, 11, 07), 12, 160527, "Jaguar", new DateTime(2018, 12, 31), 60000);

            var vehicleList = new List<Vehicle>() {vehicle1, vehicle2, vehicle3};
            return vehicleList;
        }

        static List<Phone> PhoneAdd()
        { 
            var phone1 = new Phone(Guid.NewGuid(), "Black", new DateTime(2016, 07, 16), 24, 4500, "Samsung", "yes", "0913365346", new Tuple<string, string>("Luka", "Lukanović"));
            var phone2 = new Phone(Guid.NewGuid(), "White", new DateTime(2018, 03, 25), 12, 6000, "Apple", "yes", "0989180128", new Tuple<string, string>("Ivo", "Ivić"));
            var phone3 = new Phone(Guid.NewGuid(), "Gray", new DateTime(2018, 11, 07), 24, 2500, "Huawei", "yes", "0977709000", new Tuple<string, string>("Ante", "Antić"));
            var phoneList = new List<Phone>() {phone1, phone2, phone3 };
            return phoneList;
        }

        static List<Computer> ComputerAdd()
        {
            var computer1 = new Computer(Guid.NewGuid(), "Black", new DateTime(2016, 07, 16), 24, 4500, "Apple", "yes", OperatingSystems.macOS, "yes");
            var computer2 = new Computer(Guid.NewGuid(), "White", new DateTime(2018, 03, 25), 24, 3000, "Acer", "yes", OperatingSystems.Linux, "yes");
            var computer3 = new Computer(Guid.NewGuid(), "Gray", new DateTime(2017, 11, 07), 12, 7000, "HP", "no", OperatingSystems.Windows, "no");
            var computerList = new List<Computer>() { computer1, computer2, computer3 };
            return computerList;
        }
    }
}
