using System;
using System.Collections.Generic;

HashSet<Students> students = new HashSet<Students>();

string[] courses = {"A", "B", "C"};

for (int i = 0; i < courses.Length; i++)
{
    Console.Write($"How many students for course {courses[i]}? ");
    int n = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Enter the students's IDs");
    
    for (int j = 0; j < n; j++)
    {
        int studentId = int.Parse(Console.ReadLine());
        
        students.Add( new Students {StudentId = studentId, Course = courses[j]});
    }
}

Console.WriteLine(students.Count);