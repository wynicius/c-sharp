using System;
using System.IO;
using System.Globalization;


string filePath = @"C:\Users\User1\Desktop\files-studies\items.csv";
string directoryPath = Path.GetDirectoryName(filePath);

string outFolderPath = Path.Combine(directoryPath, "out");
string targetPath = Path.Combine(outFolderPath, "summary.csv");

try
{
    if (!Directory.Exists(outFolderPath))
    {
        Directory.CreateDirectory(outFolderPath);
    }

    using (StreamWriter writer = new StreamWriter(targetPath))
    using (StreamReader reader = new StreamReader(filePath))
    {
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] parts = line.Split(',');
            string name = parts[0];
            double price = double.Parse(parts[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(parts[2]);

            Product prod = new Product(name, price, quantity);

            writer.WriteLine(prod.Name + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    Console.WriteLine("File 'summary.csv' successfully created.");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}