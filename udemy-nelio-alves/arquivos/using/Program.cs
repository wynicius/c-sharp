string path = @"c:\temp\file1.txt";
try {
    using (StreamReader sr = File.OpenText(path)) {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}