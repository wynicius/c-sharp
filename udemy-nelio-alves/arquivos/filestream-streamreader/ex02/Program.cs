using System;
using System.IO;

string path = @"c:\temp\file1.txt";
StreamReader sr = null;
try 
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream) // Loop para que o programa leia todas as linhas do arquivo até "o final da stream".
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e) 
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally 
{
    if (sr != null) sr.Close();
}