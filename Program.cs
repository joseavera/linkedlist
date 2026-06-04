using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> alumnos = new LinkedList<string>();
        alumnos.AddLast("Ana");
        alumnos.AddLast("Luis");
        alumnos.AddLast("Sofía");

        bool existe = alumnos.Contains("Luis");
        Console.WriteLine(existe);                          // True

        alumnos.Remove("Luis");
        Console.WriteLine($"Quedan: {alumnos.Count}");     // 2

        Console.WriteLine(alumnos.First.Value);            // Ana
        Console.WriteLine(alumnos.Last.Value);             // Sofía
    }
}
