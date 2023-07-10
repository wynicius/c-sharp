using System;
using System.IO;
using System.Collections.Generic;

try
{
    Dictionary<string, int> candidates = new Dictionary<string, int>();
    string path = @"C:\Users\User1\Desktop\in.csv";

    using (StreamReader sr = new StreamReader(path))
    {
        while (!sr.EndOfStream)
        {
            string[] lines = sr.ReadLine().Split(",");
            int votes = int.Parse(lines[1]);

            if (candidates.ContainsKey(lines[0]))
            {
                candidates[lines[0]] += votes;
            }
            else
            {
                candidates.Add(lines[0], votes);
            }
        }
    }

    foreach (var candidate in candidates)
    {
        Console.WriteLine(candidate.Key + ": " + candidate.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine("an error occurred: " + e.Message);
}