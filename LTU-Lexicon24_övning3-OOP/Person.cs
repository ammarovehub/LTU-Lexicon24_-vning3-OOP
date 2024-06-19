﻿namespace Encapsulation
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0) throw new ArgumentException("Age must be greater than 0.");
                age = value;
            }
        }

        public string FName
        {
            get => fName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                   throw new ArgumentException("First name must be between 2 and 10 characters.");
                fName = value;
            }
        }
        public string LName 
        {
            get => lName;
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Last name must be between 3 and 15 characters.");
                lName = value;
            }
           

        }

        public double Height
        {
            get => height;
            set => height = value;
        }
        public double Weight
        {
            get => weight;
            set => weight = value;
        }
    }

}
