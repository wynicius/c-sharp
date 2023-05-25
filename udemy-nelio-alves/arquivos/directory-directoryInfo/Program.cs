using System;
using System.IO;

string path = @"C:\Users\User1\Desktop\files-studies";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS: ");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES: ");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    Directory.CreateDirectory(path + @"\newfolder");
    Console.WriteLine("folder: 'newfolder' created");
}
catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}