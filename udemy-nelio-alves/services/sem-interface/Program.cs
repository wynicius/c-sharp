using System;
using System.Globalization;
using RentACar.Services;
using RentACar.Entities;

namespace RentACar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("------ Enter Rental Data ------");
                Console.Write("Car Model: ");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));

                Console.Write("Enter price per hour: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Enter price per day: ");
                int day = int.Parse(Console.ReadLine());

                RentalService rentalService = new RentalService(hour, day);
                rentalService.ProcessInvoice(carRental);

                Console.WriteLine();
                Console.WriteLine("INVOICE:");
                Console.WriteLine(CarRental.Invoice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e + e.Message);
            }
        }
    }
}