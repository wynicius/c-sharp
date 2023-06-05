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
            Console.WriteLine("------ Enter Rental Data ------");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}