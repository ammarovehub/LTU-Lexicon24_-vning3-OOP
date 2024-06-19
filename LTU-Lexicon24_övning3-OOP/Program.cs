using System;
using System.Collections.Generic;
using Encapsulation;

class Program
{
    static void Main(string[] args) 
    {
        PersonHandler  handler = new PersonHandler();
        Person person = handler.CreatePerson(30, "Ammar", "Jamous", 1.67, 70);
    }
}