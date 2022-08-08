using System;
using System.Collections;
using System.Collections.Generic;

public class Example
{
    public static void Main(string[] args)
    {
        Queue countries = new Queue();
        countries.Enqueue("India");
        countries.Enqueue("Australia");
        countries.Enqueue("Canada");
        countries.Enqueue("Japan");
        countries.Enqueue("Mexico");

        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        Console.WriteLine("Peek element: " + countries.Peek());
        Console.WriteLine("Dequeue: " + countries.Dequeue());
        Console.WriteLine("Peek element After Dequeue: " + countries.Peek());
    }
}