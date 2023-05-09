using System;
using System.IO;

string sourcePath = @"C:\Users\User1\Desktop\txt1.txt";
string targetPath = @"C:\Users\User1\Desktop\txt2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException ex)
{
    System.Console.WriteLine("THE FOLLOWING ERROR OCCURRED: " + ex.Message);
}