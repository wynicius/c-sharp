using System;
using System.IO;

string path = @"C:\Users\User1\Desktop\txt1.txt";
FileStream fs = null;
StreamReader sr = null;
try
{
    fs = new FileStream(path, FileMode.Open);  // Could use: File.OpenRead(path);
    sr = new StreamReader(fs);
    string line = sr.ReadLine();
    System.Console.WriteLine(line);
}
catch (IOException e)
{
    System.Console.WriteLine("An error occured: " + e.Message);
}
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}