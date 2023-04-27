using System.Globalization;

Console.WriteLine("------------------");
Console.WriteLine("------Hello!------");
Console.WriteLine("------------------");

List<Employee> listEmployess = new List<Employee>();

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) 
{
    Console.WriteLine($"Employee #{n+1} data: ");
    Console.Write("Outsourced (y/n)? ");
    char employeeType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    
    if (employeeType == 'y')
    {
        Console.WriteLine("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listEmployees.Add = (new )

    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Employee employee = new Employee(name, hours, valuePerHour);
    }

    Console.WriteLine("PAYMENTS:");
    
}


