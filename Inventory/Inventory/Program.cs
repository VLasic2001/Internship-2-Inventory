using System;
using System.Collections.Generic;
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
                }


            } while (choice != "Exit");
        }

        static void Options()
        {
            Console.WriteLine("Press the number of the action you want to take.");
            Console.WriteLine("1. Add an item to inventory.");
            Console.WriteLine("2. Delete an item from inventory.");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
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
            Console.WriteLine("Enter number of months of warranty left");
            var monthsOfWarranty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price at time of purchase");
            var purchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter manufacturer name");
            var manufacturer = Console.ReadLine();
            Console.WriteLine("Enter 'yes' if phone has a battery");
            var hasBattery = Console.ReadLine();
            Console.WriteLine($"press {(int)OperatingSystems.Windows} to select Windows as operating system");
            Console.WriteLine($"press {(int)OperatingSystems.macOS} to select macOS as operating system");
            Console.WriteLine($"press {(int)OperatingSystems.Linux} to select Linux as operating system");
            var operatingSystem = int.Parse(Console.ReadLine());
            var operatingSystemAsOperatingSystems = (OperatingSystems) operatingSystem;
            Console.WriteLine("Enter 'yes' if computer is portable");
            var isComputerPortable = Console.ReadLine();
            var newComputer = new Computer(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer, hasBattery, operatingSystemAsOperatingSystems, isComputerPortable);
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
            Console.WriteLine("Enter number of months of warranty left");
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
            var newPhone = new Phone(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer, hasBattery, phoneNumber, identity);
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
            Console.WriteLine("Enter number of months of warranty left");
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
            var newComputer = new Vehicle(serialNumber, description, dateOfPurchase, monthsOfWarranty, purchasePrice, manufacturer, licencePlateExpiryDate, kilometersDriven);
            vehicleList.Add(newComputer);
            return vehicleList;
        }

        static List<Computer> DeleteComputer(List<Computer> computerList)
        {
            foreach (var Computer in computerList)
            {
                Console.WriteLine("Enter serial number of computer you want to delete from inventory");
                if (Computer.SerialNumber == Guid.Parse(Console.ReadLine()))
                    computerList.Remove(Computer);
            }
            return computerList;
        }

        static List<Phone> DeletePhone(List<Phone> phoneList)
        {
            foreach (var Phone in phoneList)
            {
                Console.WriteLine("Enter serial number of phone you want to delete from inventory");
                if (Phone.SerialNumber == Guid.Parse(Console.ReadLine()))
                    phoneList.Remove(Phone);
            }
            return phoneList;
        }

        static List<Vehicle> DeleteVehicle(List<Vehicle> vehicleList)
        {
            foreach (var Vehicle in vehicleList)
            {
                Console.WriteLine("Enter serial number of vehicle you want to delete from inventory");
                if (Vehicle.SerialNumber == Guid.Parse(Console.ReadLine()))
                    vehicleList.Remove(Vehicle);
            }
            return vehicleList;
        }
    }
}
