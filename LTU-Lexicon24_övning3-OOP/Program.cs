using System;
using System.Collections.Generic;
using Encapsulation;

    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler handler = new PersonHandler();
            try
            {
                Person person = handler.CreatePerson(30, "Ammar", "Jamous", 1.67, 70);
                handler.SetAge(person, 10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }