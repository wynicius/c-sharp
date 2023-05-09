using System;
using System.IO;

class Program 
{
    static void Main(string[] args) 
    {
        string sourcePath = @"C:\Users\User1\Desktop\txt1.txt";
        string targetPath = @"C:\Users\User1\Desktop\txt2.txt";
        try 
        {
            File.Copy(sourcePath, targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException e) 
        {
            Console.WriteLine("An error occurred" + "\n" + e.Message);
        }
    }
}
