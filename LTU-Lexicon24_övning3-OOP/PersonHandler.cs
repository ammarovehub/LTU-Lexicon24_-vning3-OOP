﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age) 
        {
            pers.Age = age;
        }

        public void SetHeight(Person pers, int height) 
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, int weight) 
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            
        }
    }
}
