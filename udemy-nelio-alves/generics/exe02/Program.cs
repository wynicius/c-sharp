using System.Collections.Generic;
using System.IO;
using System;

HashSet<Logs> logs = new HashSet<Logs>();

string path = @"C:\Users\User1\Desktop\in.txt";

try
{   
    using (StreamReader sr = File.OpenText(path))
    {
        while(!sr.EndOfStream) 
        { 
            string[] line = sr.ReadLine().Split(" "); 
            string username = line[0];
            DateTime instance = DateTime.Parse(line[1]);

            logs.Add(new Logs { Username = username, Instance = instance }); 
        }
    }
    System.Console.WriteLine("Total users: " + logs.Count);
}
catch (IOException e)
{
    Console.WriteLine("an error occurred: " + e.Message);
}