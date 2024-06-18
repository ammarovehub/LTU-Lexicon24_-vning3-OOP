using System;
using System.Collections.Generic;
using Encapsulation;

class Program
{
    static void Main(string[] args) 
    {
        PersonHandler  handler = new personHandler();
        Person person = handler.CreatePerson(age, fname, lname, double height, double weight);
    }
}