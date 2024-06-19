using System;
using System.Collections.Generic;
using Encapsulation;

    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler handler = new PersonHandler();
            Person person1 = handler.CreatePerson(35, "Olivia", "Johanson", 1.65, 60);
            Person person2 = handler.CreatePerson(65, "Elias", "Sjölund", 1.70, 85);

            try
            {
                handler.SetAge(person1, 10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error updating person1: {ex.Message}");
            }

            try 
            {
                handler.SetWeight(person2, 60);
                handler.SetHeight(person2, 1.80);
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine($"Error updating person2: {ex.Message}");
            }

            PrintPersonDetails(person1);
            PrintPersonDetails(person2);
        }
        static void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"Person Details: Age={person.Age}, FirstName={person.FName}, LastName={person.LName}, Height={person.Height}, Weight={person.Weight}");
        }
    }
        